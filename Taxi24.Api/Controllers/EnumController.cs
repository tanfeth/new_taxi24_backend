using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Dto;

namespace Taxi24.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnumController : ControllerBase
    {
        private readonly IUserHandler userHandler;
        public EnumController(IUserHandler userHandler)
        {
            this.userHandler = userHandler;
        }
        [HttpGet("AppEnum")]
        public async Task<List<EnumDto>> GetAppEnum([FromQuery] BaseDto dto)
        {
            var result = new List<EnumDto>()
           {
                new EnumDto()
               {
                   Id = 2,
                   Name = userHandler.GetLanguage() == "en" ? "Passanger" : "العميل"
               },
               new EnumDto()
               {
                   Id = 3,
                   Name = userHandler.GetLanguage() == "en" ? "Driver" : "الكابتن"
               }
           };
            return result;
        }

        [HttpGet("GenderEnum")]
        public async Task<List<EnumDto>> GetGendeEnum([FromQuery] BaseDto dto)
        {
            var result = new List<EnumDto>()
           {
                new EnumDto()
               {
                   Id = 0,
                   Name = userHandler.GetLanguage() == "en" ? "Male" : "ذكر"
               },
               new EnumDto()
               {
                   Id = 1,
                   Name =userHandler.GetLanguage() == "en" ? "Female" : "أنثى"
               }
           };
            return result;
        }


        [HttpGet("AttachmentStatesEnum")]
        public async Task<List<EnumDto>> GetAttachmentStatesEnum()
        {
            var result = new List<EnumDto>()
           {
                new EnumDto()
               {
                    Id = 1,
                   Name = userHandler.GetLanguage() == "en" ? "Empty" : "فارغ"
               },
               new EnumDto()
               {
                   Id = 2,
                   Name = userHandler.GetLanguage() == "en" ? "Pending" : "جاري المراجعة"
               },
               new EnumDto()
               {
                   Id = 3,
                   Name = userHandler.GetLanguage() == "en" ? "Approved" : "موافقة"
               },
               new EnumDto()
               {
                   Id = 4,
                   Name = userHandler.GetLanguage() == "en" ? "Rejected" : "رفض"
               },


           };
            return result;
        }

        [HttpGet("AccountStatesEnum")]
        public async Task<List<EnumDto>> GetAccountStatesEnum()
        {
            var result = new List<EnumDto>()
           {

               new EnumDto()
               {
                   Id = 2,
                   Name = userHandler.GetLanguage() == "en" ? "Pending" : "جاري المراجعة"
               },
               new EnumDto()
               {
                   Id = 3,
                   Name = userHandler.GetLanguage() == "en" ? "Approved" : "موافقة"
               },
               new EnumDto()
               {
                   Id = 4,
                   Name = userHandler.GetLanguage() == "en" ? "Rejected" : "رفض"
               }
           };
            return result;
        }



    }
}
