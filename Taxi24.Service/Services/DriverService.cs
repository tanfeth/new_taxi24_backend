
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
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
using Taxi24.Service.IocExtensions;
using Taxi24.Service.MappersExtensions;


namespace Taxi24.Service.Services
{
    public class DriverService : IDriverService
    {

        private readonly IDriverRepository driverRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IMapper mapper;
        private IValidator<RegisterDriverDto> validator;
        public DriverService(IHttpContextAccessor httpContextAccessor,
            IValidator<RegisterDriverDto> validator,
            IHostingEnvironment hostingEnvironment,
            IDriverRepository driverRepository,
            IMapper mapper)
        {
            this.validator = validator;
            this.mapper = mapper;
            this.driverRepository = driverRepository;
            this.httpContextAccessor = httpContextAccessor;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<DriverProfileResponse> GetDriverProfileResponse()
        {
            var model = new DriverProfileResponse();
            var driver = await driverRepository.GetLoggedInDriver();
            if (driver == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.DriverNotExists.SetError());
                return model;
            }
            model.Name = driver?.User?.Name;
            model.Gender = driver?.User?.Gender;
            model.DateOfBirthHijri = driver?.User?.DateOfBirthHijri;
            model.Email = driver?.User?.Email;
            model.Mobile = driver?.User?.UserName;
            model.DateOfBirth = driver?.User?.DateOfBirth;
            model.ProfileImage = "https://devapi.taxi24.app/Files/" + driver?.User?.ProfileImage;
            model.IsProfileImageEditied = driver?.User?.ProfileImageEdited != null;
            if (model.IsProfileImageEditied)
            {
                model.ProfileImageEditedState = driver?.User?.ProfileImageEditedState;
                model.ProfileImageEditedStateNote = driver?.User?.ProfileImageEditedStateNote;
            }
            return model;

        }

        public async Task<UpdateDriver> Update(UpdateDriver update)
        {
            var driver = await driverRepository.GetLoggedInDriver();
            if (driver == null && driver?.User != null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.DriverNotExists.SetError());
                return update;
            }
            driver.User.Name = update.Name ?? driver?.User?.Name;
            driver.User.Gender = update.Gender ?? driver?.User?.Gender;
            driver.User.Email = update.Email ?? driver?.User?.Email;
            if (update.DateOfBirth != null)
            {
                driver.User.DateOfBirth = update.DateOfBirth;
                driver.User.DateOfBirthHijri = update.DateOfBirth.Value.Year.ToString() + "/" + update.DateOfBirth.Value.Month.ToString()?.PadLeft(2, '0') + "/" +
                update.DateOfBirth.Value.Day.ToString()?.PadLeft(2, '0');
            }
            await driverRepository.UpdateAsync(driver);
            return update;

        }



        public async Task<DriverStatus> GetAccountStatus()
        {
            var model = new DriverStatus();
            var driver = await driverRepository.GetLoggedInDriver();
            if (driver == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.UserNotExists.SetError());
                return model;
            }

            var car = driver?.Cars?.FirstOrDefault(x => x.IsDefault);
            //Driver Status
            model.ProfileImageState = driver?.User?.ProfileImageState ?? ImagesStatusEnum.Empty;
            model.SaudiIdImageState = driver?.SaudiIdImageState ?? ImagesStatusEnum.Empty;
            model.LicenseImageState = driver?.LicenseImageState ?? ImagesStatusEnum.Empty;
            model.DriverEligibilty = driver?.Eligibility ?? ImagesStatusEnum.Empty;
            model.ProfileImageStateNote = driver?.User?.ProfileImageStateNote;
            model.SaudiIdImageStateNote = driver?.SaudiIdImageStateNote;
            model.LicenseImageStateNote = driver?.LicenseImageStateNote;

            //Car Status
            model.CarId = car?.Id;
            model.CarInssuranceState = car?.CarInssuranceState ?? ImagesStatusEnum.Empty;
            model.CarRegistrationState = car?.CarRegistrationState ?? ImagesStatusEnum.Empty;
            model.CarInssuranceStateNote = car?.CarInssuranceStateNote;
            model.CarRegistrationStateNote = car?.CarRegistrationStateNote;
            model.CarEligibilty = car?.Eligibility ?? ImagesStatusEnum.Empty;
            return model;

        }

        public async Task<bool> UpdateDriverAttachments(UpdateDriverAttachments update)
        {
            bool updateSuccessflly = false;
            var driver = await driverRepository.GetLoggedInDriver();
            if (driver == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.UserNotExists.SetError());
                return updateSuccessflly;
            }

            if (update.SaudiIdExpiryDate != null && update.SaudiIdExpiryDate <= DateTime.Now)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.SaudiIdExpiryDateMustBeGreaterThanNow.SetError());
                return updateSuccessflly;
            }

            if (update.LicenceExpiryDate != null && update.LicenceExpiryDate <= DateTime.Now)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.DriverLicenseMustBeGreaterThanNow.SetError());
                return updateSuccessflly;
            }



            if (update.ProfileImage != null)
            {
                if (driver.User.ProfileImageState == ImagesStatusEnum.Approved)
                {
                    driver.User.ProfileImageEdited = await update.ProfileImage.saveFile(driver.User.Name, hostingEnvironment.WebRootPath);
                    driver.User.ProfileImageEditedState = ImagesStatusEnum.Pending;
                }
                else
                {
                    driver.User.ProfileImage = await update.ProfileImage.saveFile(driver.User.Name, hostingEnvironment.WebRootPath);
                    driver.User.ProfileImageState = ImagesStatusEnum.Pending;
                }

            }
            if (update.License != null)
            {
                driver.License = await update.ProfileImage.saveFile(driver.License, hostingEnvironment.WebRootPath);
                driver.LicenseImageState = ImagesStatusEnum.Pending;
            }

            if (update.SaudiId != null)
            {
                driver.SaudiId = await update.SaudiId.saveFile(driver.User.Name, hostingEnvironment.WebRootPath);
                driver.SaudiIdImageState = ImagesStatusEnum.Pending;
            }

            driver.SaudiIdExpiryDate = update.SaudiIdExpiryDate ?? driver.SaudiIdExpiryDate;
            driver.LicenceExpiryDate = update.LicenceExpiryDate ?? driver.LicenceExpiryDate;
            var result = await driverRepository.UpdateAsync(driver);


            return result > 0;

        }
    }
}
