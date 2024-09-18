using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Dto;
using Taxi24.Core.IServices;
using Taxi24.Core.Response;

namespace Taxi24.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController : ControllerBase
    {
        private readonly ICarService carService;
        private readonly IDriverService driverService;
        public CarController(ICarService carService, IDriverService driverService)
        {
            this.carService = carService;
            this.driverService = driverService;
        }


        [HttpGet("GetCarTypes")]
        [Authorize]
        public async Task<List<LookupValuesDto>> GetCarTypes()
        {
            var carTypes = await carService.GetCarTypes();
            return carTypes;
        }

        [HttpGet("GetCarModels")]
        [Authorize]
        public async Task<List<LookupValuesDto>> GetCarModels([FromQuery] string carTypeCode)
        {
            var carTypes = await carService.GetCarModels(carTypeCode);
            return carTypes;
        }


        [HttpPost("InsertCar")]
        [Authorize]
        public async Task<DriverStatus> InsertCar([FromForm]RegisterCarDto register)
        {
            var car = await carService.InsertCar(register);
            var accountStatus = await driverService.GetAccountStatus();
            return accountStatus;
        }

        [HttpPost("UploadCarAttachments")]
        [Authorize]
        public async Task<DriverStatus> UploadCarAttachments([FromForm]UploadCarAttachments attachments)
        {
            var car = await carService.UploadCarAttachments(attachments);
            var accountStatus = await driverService.GetAccountStatus();
            return accountStatus;
        }

        [HttpGet("GetDriverCarsResponse")]
        [Authorize]
        public async Task<List<GetDriverCarsResponse>> GetCarResponseDto()
        {
            var cars = await carService.GetDriverCars();
            return cars;
        }

    }
}
