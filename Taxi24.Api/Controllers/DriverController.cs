using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Dto;
using Taxi24.Core.IServices;
using Taxi24.Core.Response;
using Taxi24.Infra.Handlers;
using Taxi24.Service.Services;

namespace Taxi24.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService driverService;
        private readonly IUserHandler userHandler;
        public DriverController(IDriverService driverService,
            IUserHandler userHandler)
        {
            this.driverService = driverService;
            this.userHandler = userHandler;
        }


        [HttpPut]
        [Authorize(Roles = "Driver")]

        public async Task<UpdateDriver> Update(UpdateDriver update)
        {
            var result = await driverService.Update(update);
            return result;
        }


        [HttpPost("UploadDriverAttachment")]
        [Authorize(Roles = "Driver")]
        public async Task<DriverStatus> UploadDriverAttachment([FromForm] UpdateDriverAttachments attachments)
        {
            var model = await driverService.UpdateDriverAttachments(attachments);
            var accountStatus = await AccountStatus();
            return accountStatus;
        }

       


        [HttpGet("AccountStatus")]
        [Authorize(Roles = "Driver")]

        public async Task<DriverStatus> AccountStatus()
        {
            var result = await driverService.GetAccountStatus();
            return result;
        }

        [HttpGet("DriverProfileResponse")]
        [Authorize(Roles = "Driver")]

        public async Task<DriverProfileResponse> GetDriverProfile()
        {
            var result = await driverService.GetDriverProfileResponse();
            return result;
        }

       



    }
}
