
using Taxi24.Core.Response;

namespace Taxi24.Core.Dto
{
    public class DriverStatus : CarStatus
    {
        public string? LicenseImageState { get; set; }
        public string? SaudiIdImageState { get; set; }
        public string? ProfileImageState { get; set; }
        public string? DriverEligibilty { get; set; }
        public string? LicenseImageStateNote { get; set; }
        public string? SaudiIdImageStateNote { get; set; }
        public string? ProfileImageStateNote { get; set; }
    }
    public class CarStatus
    {
        public string? CarDetailsState { get; set; }
        public string? CarRegistrationState { get; set; }
        public string? CarInssuranceState { get; set; }
        public string? CarRegistrationStateNote { get; set; }
        public string? CarInssuranceStateNote { get; set; }
        public string? CarEligibilty { get; set; }
        public int? CarId { get; set; }
    }
}
