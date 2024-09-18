

using Taxi24.Core.Dto;
using Taxi24.Core.Response;

namespace Taxi24.Core.IServices
{
    public interface ICarService
    {
        Task<List<LookupValuesDto>> GetCarTypes();

        Task<List<LookupValuesDto>> GetCarModels(string parentCode);

        Task<RegisterCarDto> InsertCar(RegisterCarDto registerCar);

        Task<bool> UploadCarAttachments(UploadCarAttachments carAttachments);
        Task<List<GetDriverCarsResponse>> GetDriverCars();
    }
}
