using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class UploadCarAttachments
    {
        public int? CarId { get; set; }
        public IFormFile? CarInsurance { get; set; }
        public DateTime? CarInsuranceExpiryDate { get; set; }
        public IFormFile? VehicalRegistration { get; set; }
        public DateTime? VehicalRegistrationExpiryDate { get; set; }
    }
}
