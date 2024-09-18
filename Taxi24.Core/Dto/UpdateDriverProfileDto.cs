using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Dto
{
    public  class UpdateDriverProfileDto
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Date { get; set; }
        public Gender? Gender { get; set; }
    }
}
