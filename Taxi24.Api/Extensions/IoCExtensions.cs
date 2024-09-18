
using FluentValidation;
using System;
using System.Reflection;
using Taxi24.Api.Middleware;
using Taxi24.Core.Dto;
using Taxi24.Core.IServices;
using Taxi24.Core.Validator;
using Taxi24.Service.IocExtensions;
using Taxi24.Service.Services;

namespace Taxi24.Api.Common.Extensions
{
    public static class IoCExtensions
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IDriverService, DriverService>();
            services.AddScoped<ICarService, CarService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<ErrorHandlingMiddleware>();
            services.AddTransient<ApiKeyMiddleware>();
            services.RegisterRepositories();

            #region Validators

            services.AddScoped<IValidator<RegisterDriverDto>, RegisterDriverValidator>();
            services.AddScoped<IValidator<RegisterCarDto>, RegisterCarValidator>();

            #endregion
        }



    }
}
