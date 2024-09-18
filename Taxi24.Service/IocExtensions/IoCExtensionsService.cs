using Microsoft.Extensions.DependencyInjection;
using Taxi24.Core.Common.Handler;
using Taxi24.Core.Common.IHandler;
using Taxi24.Core.Common.IHelper;
using Taxi24.Core.IRepository;
using Taxi24.Core.Repository;
using Taxi24.Infra.Handler;
using Taxi24.Infra.Handlers;
using Taxi24.Infra.Repository;

namespace Taxi24.Service.IocExtensions
{
    public static  class IoCExtensionsService
    {

        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserHandler , UserHandler>();
            services.AddScoped<INotificationHandler, NotificationHandler>();
            services.AddScoped<IApiHelper, ApiHelper>();


            services.AddScoped<IUserRepository , UserRepository>();
            services.AddScoped<IDriverRepository , DriverRepository>();
            services.AddScoped<ICarRepository , CarRepository>();
            services.AddScoped<ILookupValuesRepository, LookupValuesRepository>();
            services.AddScoped<INotificationRepository , NotificationRepository>();
        }
    }
}
