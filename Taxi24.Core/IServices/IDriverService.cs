

using Taxi24.Core.Dto;
using Taxi24.Core.Response;

namespace Taxi24.Core.IServices
{
    public interface IDriverService
    {
        Task<DriverStatus> GetAccountStatus();
        Task<bool> UpdateDriverAttachments(UpdateDriverAttachments update);
        Task<DriverProfileResponse> GetDriverProfileResponse();
        Task<UpdateDriver> Update(UpdateDriver update);
    }
}
