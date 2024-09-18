using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Entity;

namespace Taxi24.Core.Dto
{
    public class CarDto
    {
        public int Id { get; set; }
        public string? CarType { get; set; }
        public string? CarModel { get; set; }
        public int? CarYear { get; set; }
        public string? CarCollor { get; set; }
        public string? CarRegistration { get; set; }
        public DateTime? CarRegistrationExpiryDate { get; set; }
        public string? CarInssurance { get; set; }
        public DateTime? CarInssuranceExpiryDate { get; set; }
        public string? PlateNo { get; set; }
        public int DriverId { get; set; }
        public string? CarDetailsState { get; set; }
        public string? CarRegistrationState { get; set; }
        public string? CarInssuranceState { get; set; }
        public bool IsDefault { get; set; }
        public string? PlateLetterRight { get; set; }
        public string? PlateLetterMiddle { get; set; }
        public string? PlateLetterLeft { get; set; }
        public string? PlateType { get; set; }
        public CarSeatType? CarSeatType { get; set; }
        public virtual IEnumerable<Photos> Photos { get; set; }
        public string? Eligibility { get; set; }
    }
}
