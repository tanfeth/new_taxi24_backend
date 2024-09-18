using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Dto;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Response
{
    public class LoginResponse
    {
        //public string? Token { get; set; }
        public string AccountState { get; set; }
        public bool IsInTrip { get; set; }
    }
}
