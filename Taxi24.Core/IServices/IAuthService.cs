

using Taxi24.Core.Dto;
using Taxi24.Core.Response;

namespace Taxi24.Core.IServices
{
    public interface IAuthService
    {
        Task<LoginResponse> VerifyCode(VerifiyCode verifyCode);
        Task<SendCodeResponse> Login(LoginDto login);
        Task<RegisterDriverDto> RegisterDriver(RegisterDriverDto register);
        Task<UpdateDeviceTokenDto> UpdateDeviceToken(UpdateDeviceTokenDto update);
    }
}
