using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Dto;
using Taxi24.Core.IServices;
using Taxi24.Core.Repository;
using Taxi24.Core.Response;

namespace Taxi24.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IUserHandler userHandler;
        private readonly IHttpContextAccessor httpContextAccessor;

        public AuthController(IAuthService authService,
            IUserHandler userHandler,
            IHttpContextAccessor httpContextAccessor)
        {
            this.authService = authService;
            this.userHandler = userHandler;
            this.httpContextAccessor = httpContextAccessor;
        }

        [HttpPost("login")]

        public async Task<SendCodeResponse> Login(LoginDto login)
        {
            var result = await authService.Login(login);
            return result;
        }

        /// <remarks>
        ///  Role User 2
        /// Role Driver 3
        /// </remarks>
        [HttpPost("Verify")]
        public async Task<LoginResponse> VerifyCode(VerifiyCode verifyCode)
        {
            var result = await authService.VerifyCode(verifyCode);
            return result;
        }

        [HttpPost("Register/Driver")]
        public async Task<RegisterDriverDto> RegisterDriver(RegisterDriverDto register)
        {
            var result = await authService.RegisterDriver(register);
            return register;
        }



        [HttpGet("GetCities")]
        public async Task<List<EnumDto>> GetCities([FromQuery] BaseDto dto)
        {
            var cities = new List<EnumDto>
{
    new EnumDto { Id = 1, Name = userHandler.GetLanguage() == "en" ? "Dammam" : "الدمام" },
    new EnumDto { Id = 2, Name = userHandler.GetLanguage() == "en" ? "Riyadh" : "الرياض" },
    new EnumDto { Id = 3, Name = userHandler.GetLanguage() == "en" ? "Jeddah" : "جدة" },
    new EnumDto { Id = 4, Name = userHandler.GetLanguage() == "en" ? "Makkah" : "مكة" },
    new EnumDto { Id = 5, Name = userHandler.GetLanguage() == "en" ? "Madinah" : "المدينة المنورة" },
    new EnumDto { Id = 6, Name = userHandler.GetLanguage() == "en" ? "Taif" : "الطائف" },
    new EnumDto { Id = 7, Name = userHandler.GetLanguage() == "en" ? "Khobar" : "الخبر" },
    new EnumDto { Id = 8, Name = userHandler.GetLanguage() == "en" ? "Buraydah" : "بريدة" },
    new EnumDto { Id = 9, Name = userHandler.GetLanguage() == "en" ? "Tabuk" : "تبوك" },
    new EnumDto { Id = 10, Name = userHandler.GetLanguage() == "en" ? "Hail" : "حائل" },
    new EnumDto { Id = 11, Name = userHandler.GetLanguage() == "en" ? "Dhahran" : "الظهران" },
    new EnumDto { Id = 12, Name = userHandler.GetLanguage() == "en" ? "Jubail" : "الجبيل" },
    new EnumDto { Id = 13, Name = userHandler.GetLanguage() == "en" ? "Najran" : "نجران" },
    new EnumDto { Id = 14, Name = userHandler.GetLanguage() == "en" ? "Abha" : "أبها" },
    new EnumDto { Id = 15, Name = userHandler.GetLanguage() == "en" ? "Al-Kharj" : "الخرج" },
    new EnumDto { Id = 16, Name = userHandler.GetLanguage() == "en" ? "Yanbu" : "ينبع" },
    new EnumDto { Id = 17, Name = userHandler.GetLanguage() == "en" ? "Sakaka" : "سكاكا" },
    new EnumDto { Id = 18, Name = userHandler.GetLanguage() == "en" ? "Jizan" : "جيزان" },
    new EnumDto { Id = 19, Name = userHandler.GetLanguage() == "en" ? "Al-Qurayyat" : "القريات" },
    new EnumDto { Id = 20, Name = userHandler.GetLanguage() == "en" ? "Rafha" : "رفحاء" }
};

            dto.PageNumber = dto.PageNumber == null || dto.PageNumber < 1 ? 1 : dto.PageNumber;
            cities = cities.Skip((dto.PageNumber.Value - 1) * dto.PageSize.Value).Take(dto.PageSize.Value).ToList();
            int totalPages = (int)Math.Ceiling((double)20 / dto.PageSize.Value);
            var pagenation = new Pagenation()
            {
                CurrentPage = dto.PageNumber.Value,
                TotalCount = 20,
                TotalPages = totalPages,
                PageSize = dto.PageSize.Value,

            };
            httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Pageination, pagenation.ToJsonString());
            return cities;
        }


        [HttpPut("device-token")]
        [Authorize]
        public async Task<UpdateDeviceTokenDto> UpdateDeviceToken(UpdateDeviceTokenDto updateDeviceToken)
        {
            return await authService.UpdateDeviceToken(updateDeviceToken);
        }




    }
}
