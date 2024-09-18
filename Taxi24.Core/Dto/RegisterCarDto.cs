using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi24.Core.Dto
{
    public class RegisterCarDto
    {
        public int? CarTypeId { get; set; }
        public int? CarModelId { get; set; }
        public int? CarYear { get; set; }
        public string? PlateType { get; set; }
        public string? PlateNumber { get; set; }
        public string? PlateLetterRight { get; set; }
        public string? PlateLetterMiddle { get; set; }
        public string? PlateLetterLeft { get; set; }
        public List<IFormFile>? Images { get; set; }
    }
}
