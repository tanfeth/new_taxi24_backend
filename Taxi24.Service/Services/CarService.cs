
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Text;
using Taxi24.Core.Common;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.Handler;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Dto;
using Taxi24.Core.Entity;
using Taxi24.Core.IRepository;
using Taxi24.Core.IServices;
using Taxi24.Core.Repository;
using Taxi24.Core.Response;
using Taxi24.Service.IocExtensions;
using Taxi24.Service.MappersExtensions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;


namespace Taxi24.Service.Services
{
    public class CarService : ICarService
    {

        private readonly ICarRepository carRepository;

        private readonly IMapper mapper;
        private readonly ILookupValuesRepository lookupValuesRepository;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IHostingEnvironment hostingEnvironment;
        private readonly IDriverRepository driverRepository;

        private IValidator<RegisterCarDto> validator;
        public CarService(IHttpContextAccessor httpContextAccessor,
            IValidator<RegisterCarDto> validator,
            IHostingEnvironment hostingEnvironment,
            ILookupValuesRepository lookupValuesRepository,
            IDriverRepository driverRepository,
            IUserHandler userHandler,
            ICarRepository carRepository,
            IMapper mapper)
        {
            this.mapper = mapper;
            this.carRepository = carRepository;
            this.lookupValuesRepository = lookupValuesRepository;
            this.validator = validator;
            this.httpContextAccessor = httpContextAccessor;
            this.hostingEnvironment = hostingEnvironment;
            this.driverRepository = driverRepository;
        }


        public async Task<List<LookupValuesDto>> GetCarTypes()
        {
            var carTypes = await lookupValuesRepository.GetAll(x => x.LookupId == 1).ToListAsync();
            var lang = carRepository.GetLang();
            var mappedCarTypes = carTypes.Select(x => new LookupValuesDto
            {
                Id = x.Id,
                Name = lang == LanguageEnumName.English ? x.NameEn : x.NameAr,
                Code = x.Code
            }).ToList();

            return mappedCarTypes;
        }

        public async Task<List<LookupValuesDto>> GetCarModels(string parentCode)
        {
            var carModels = await lookupValuesRepository.GetAll(x => x.ParentCode == parentCode).ToListAsync();
            var lang = carRepository.GetLang();
            var mappedCarModels = carModels.Select(x => new LookupValuesDto
            {
                Id = x.Id,
                Name = lang == LanguageEnumName.English ? x.NameEn : x.NameAr
            }).ToList();
            return mappedCarModels;
        }

        public async Task<RegisterCarDto> InsertCar(RegisterCarDto registerCar)
        {
            var result = await validator.ValidateAsync(registerCar);
            var userId = carRepository.GetUserId();
            if (!result.IsValid)
            {
                var error = result.Errors.FirstOrDefault();
                if (error != null)
                {
                    httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, error.ErrorMessage.SetError());
                    return registerCar;
                }
            }
            var driver = await driverRepository.GetLoggedInDriver();
            if (driver == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.DriverNotExists.SetError());
                return registerCar;
            }
            var mappedEntity = mapper.Map<Car>(registerCar);
            mappedEntity.IsDefault = true;
            List<Photos> photos = new List<Photos>();
            registerCar.Images?.ForEach(item =>
            {
                Photos photo = new Photos()
                {
                    ModelId = mappedEntity.Id,
                    Type = "Car",
                    Image = item?.saveFile(mappedEntity?.CarType, hostingEnvironment?.WebRootPath)?.Result,
                    CreationDate = DateTime.Now,
                    CreationUser = userId
                };
                photos.Add(photo);
            });
            mappedEntity.Photos = photos;
            mappedEntity.CarDetailsState = ImagesStatusEnum.Pending;
            mappedEntity.DriverId = driver.Id;
            await carRepository.AddAsync(mappedEntity);
            return registerCar;
        }

        public async Task<bool> UploadCarAttachments(UploadCarAttachments carAttachments)
        {
            bool updateSuccessflly = false;
            var userId = carRepository.GetUserId();
            if (userId == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.UserNotExists.SetError());
                return updateSuccessflly;
            }

            if (carAttachments.CarInsurance != null && carAttachments.CarInsuranceExpiryDate <= DateTime.Now)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.CarInsuranceExpired.SetError());
                return updateSuccessflly;
            }

            if (carAttachments.VehicalRegistration != null && carAttachments.VehicalRegistrationExpiryDate <= DateTime.Now)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.CarRegistrationExpired.SetError());
                return updateSuccessflly;
            }
            var car = new Car();
            if (carAttachments.CarId != null)
            {
                car = await carRepository.Get(carAttachments.CarId.Value);
            }
            else
            {
                car = await carRepository.GetDefaultCar(userId.Value);
                if (car == null)
                {
                    httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.PleaseRegisterCar.SetError());
                    return updateSuccessflly;
                }
            }

            if (carAttachments.CarInsurance != null)
            {
                car.CarInssurance = await carAttachments.CarInsurance.saveFile("Car Insurance", hostingEnvironment.WebRootPath);
                car.CarInssuranceState = ImagesStatusEnum.Pending;
            }
            if (carAttachments.VehicalRegistration != null)
            {
                car.CarInssurance = await carAttachments.VehicalRegistration.saveFile("Car Insurance", hostingEnvironment.WebRootPath);
                car.CarRegistrationState = ImagesStatusEnum.Pending;
            }

            car.CarInssuranceExpiryDate = carAttachments.CarInsuranceExpiryDate ?? car.CarInssuranceExpiryDate;
            car.CarRegistrationExpiryDate = carAttachments.VehicalRegistrationExpiryDate ?? car.CarRegistrationExpiryDate;
            var result = await carRepository.UpdateAsync(car);
            return result > 0;
        }

        public async Task<List<GetDriverCarsResponse>> GetDriverCars()
        {
            var model = new List<GetDriverCarsResponse>();
            var driver = await driverRepository.GetLoggedInDriver();
            var lang = driverRepository.GetLang();
            if (driver == null)
            {
                httpContextAccessor.HttpContext.Response.Headers.Add(ResponseMessageEnum.Status, ErrorMessages.DriverNotExists.SetError());
                return model;
            }
            model = driver.Cars.Select(x => new GetDriverCarsResponse
            {
                CarCollor = x.CarCollor,
                CarModel = lang == LanguageEnumName.English ? x.CarModelLookup?.NameEn : x?.CarModelLookup?.NameAr,
                CarType = lang == LanguageEnumName.English ? x.CarTypeLookup?.NameEn : x?.CarTypeLookup?.NameAr,
                Plate = $"{x.PlateNo} - {x.PlateLetterLeft}{x.PlateLetterMiddle}{x.PlateLetterRight}",
                Year = x.CarYear
            }).ToList();

            return model;

        }
    }
}
