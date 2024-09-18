
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Taxi24.Core.Common;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.Handler;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Dto;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;
using Taxi24.Core.IServices;
using Taxi24.Core.Response;
using Taxi24.Service.MappersExtensions;

namespace Taxi24.Service.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository userRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IConfiguration configuration;
        private readonly INotificationHandler notificationHandler;
        private readonly INotificationRepository notificationRepository;
        private readonly IMapper mapper;
        private IValidator<RegisterDriverDto> validator;
        public AuthService(IUserRepository userRepository,
            IHttpContextAccessor httpContextAccessor,
            INotificationHandler notificationHandler,
            INotificationRepository notificationRepository,
            IValidator<RegisterDriverDto> validator,
            IMapper mapper,
            IConfiguration configuration)
        {
            this.userRepository = userRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.configuration = configuration;
            this.notificationHandler = notificationHandler;
            this.notificationRepository = notificationRepository;
            this.validator = validator;
            this.mapper = mapper;
        }


        public async Task<LoginResponse> VerifyCode(VerifiyCode login)
        {
            var model = new LoginResponse();
            var user = await userRepository.FirstOrDefaultAsync(x =>
            x.UserName == login.PhoneNumber
            && x.Code == login.Code,
            include: x => x.Include(x => x.UserRoles).Include(x => x.Driver).ThenInclude(x => x.Cars));

            if (user == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.UserNameOrCodeIsIncorrect.SetError());
                return model;
            }

            if (login.AppEnum == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.AppEnumRequired.SetError());
                return model;
            }

            #region Add Role if not exists
            if (!user.UserRoles.Any(x => x.RoleId == (int)login.AppEnum))
            {
                var userRole = new UserRole()
                {
                    RoleId = (int)login.AppEnum,
                    UserId = user.Id
                };
                user.UserRoles.Add(userRole);
                await userRepository.UpdateAsync(user);
            }
            #endregion

            if (login.AppEnum == RoleEnum.Driver)
            {
                model = user.MapDriverLoginResponse();
            }
            else
                model = user.MapPassangerResponse();

            string token = "Bearer " + GenerateToken(user, login.AppEnum.ToString());
            httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Authorization, token);
            return model;
        }

        public async Task<SendCodeResponse> Login(LoginDto login)
        {
            var model = new SendCodeResponse();
            var phoneNumber = login.PhoneNumber;
            if (phoneNumber == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.PhoneNumberRequired.SetError());
                model.Success = false;
                return model;
            }


            phoneNumber = phoneNumber?.Trim()?.Replace(" ", "");
            string code = "0000";
            //string code = phoneNumber == "966555555555" || phoneNumber.Contains("500000000") ? "0000" : GenerateCode();
            User user = await userRepository.FirstOrDefaultAsync(x => x.UserName == phoneNumber);
            if (user == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.PhoneNumberNotExists.SetError());
                model.Success = false;
                return model;
            }
            NotificationDto notifi = new NotificationDto()
            {
                PhoneNumber = phoneNumber,
                Code = code,
            };

            model.Success = code == "0000" ? true : await notificationHandler.SendSMSAsync(notifi);
            user.Code = code;
            if (model.Success)
            {
                Notification notification = new Notification()
                {
                    UserId = user.Id,
                    Body = user.Code,
                    Title = "Verify Mobile Number"
                };
                await notificationRepository.AddAsync(notification);
                return model;
            }



            user.ModificationDate = DateTime.Now;
            await userRepository.UpdateAsync(user);
            return model;
        }

        public async Task<RegisterDriverDto> RegisterDriver(RegisterDriverDto register)
        {
            var result = await validator.ValidateAsync(register);

            if (!result.IsValid)
            {
                var error = result.Errors.FirstOrDefault();
                if (error != null)
                {
                    httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, error.ErrorMessage.SetError());
                    return register;
                }
            }

            var isUserExists = await userRepository.FirstOrDefaultAsync(x => x.UserName == register.UserName || x.IdentityNumber == register.IdentityNumber);
            if (isUserExists != null)
            {
                if (isUserExists.UserName == register.UserName)
                    httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.PhoneNumberAlreadyInUse.SetError());
                else
                    httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.IdentityNumberAlreadyExists.SetError());

                return register;
            }

            var mappedUser = mapper.Map<User>(register);
            mappedUser.UserRoles = new List<UserRole> { new UserRole() { RoleId = 3 } };

            if (register.DateOfBirth != null)
            {
                mappedUser.DateOfBirthHijri = register.DateOfBirth.Value.Year.ToString() + "/" + register.DateOfBirth.Value.Month.ToString()?.PadLeft(2, '0') + "/" +
                    register.DateOfBirth.Value.Day.ToString()?.PadLeft(2, '0');
            }
            mappedUser.Driver = new Driver
            {
                DriverNumber = Utlities.GenerateUniqueId(),
                UserId = mappedUser.Id,
                Status = StatusEnum.InActive
            };
            mappedUser.Code = "0000";
            await userRepository.AddAsync(mappedUser);
            await Login(new LoginDto { PhoneNumber = register.UserName });
            return register;
        }





        #region Private Methods

        private string GenerateToken(User user, string role)
        {
            var issuer = configuration["Jwt:Issuer"];
            var audience = configuration["Jwt:Audience"];
            var key = Encoding.ASCII.GetBytes
        (configuration["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {

                Subject = new ClaimsIdentity(new[]
                {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Name, user.Name),
                new Claim(ClaimTypes.Role, role),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti,
                Guid.NewGuid().ToString())
             }),
                Expires = DateTime.UtcNow.AddDays(3),
                Issuer = issuer,
                Audience = audience,
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtToken = tokenHandler.WriteToken(token);
            var stringToken = tokenHandler.WriteToken(token);
            return stringToken;
        }

        private string GenerateCode()
        {
            Random r = new Random();
            int randNum = r.Next(1000);
            string fourDigitNumber = randNum.ToString("D4");
            return fourDigitNumber;
        }

        public async Task<UpdateDeviceTokenDto> UpdateDeviceToken(UpdateDeviceTokenDto update)
        {
            var userId = userRepository.GetUserId();

            if (userId == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.UserNotExists.SetError());
                return update;
            }
            var user = await userRepository.Get((int)userId);
            if (user != null)
            {
                user.DeviceToken = update.DeviceToken;
                await userRepository.UpdateAsync(user);
            }
            return update;
        }

        #endregion

    }
}
