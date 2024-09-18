using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Dto
{
    public class LoginDto 
    {
        public string? PhoneNumber { get; set; }
    }

    public class VerifiyCode
    {
        public string? PhoneNumber { get; set; }
        public string? Code { get; set; }
        public RoleEnum? AppEnum { get; set; }
    }
}
