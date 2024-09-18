using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Dto
{
    public class RegisterDriverDto
    {
        public string? Name { get; set; }
        public string? IdentityNumber { get; set; }
        public string? UserName { get; set; }
        //public string? City { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //public string? DateOfBirthHijri { get; set; }
        public Gender? Gender { get; set; }
        public string? DeviceToken { get; set; }
        //public string? Role { get; set; }
        public int CityId { get; set; }
    }

    public class UpdateDriverAttachments
    {
        public IFormFile? ProfileImage { get; set; }
        public IFormFile? License { get; set; }
        public DateTime? LicenceExpiryDate { get; set; }
        public IFormFile? SaudiId { get; set; }
        public DateTime? SaudiIdExpiryDate { get; set; }
    }

}
