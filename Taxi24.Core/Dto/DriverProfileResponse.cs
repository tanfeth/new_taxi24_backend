using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;

namespace Taxi24.Core.Dto
{
    public class DriverProfileResponse
    {
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public int Rate { get; set; } = 1;
        public int ComplationRate { get; set; } = 50;
        public int AcceptanceRate { get; set; } = 50;
        public string? DateOfBirthHijri { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public Gender? Gender { get; set; }
        public string? ProfileImage { get; set; }
        public bool IsProfileImageEditied { get; set; }
        public string? ProfileImageEditedState { get; set; }
        public string? ProfileImageEditedStateNote { get; set; }
    }
}
