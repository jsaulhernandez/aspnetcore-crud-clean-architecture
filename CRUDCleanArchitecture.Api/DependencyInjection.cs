using CRUDCleanArchitecture.Application;
using CRUDCleanArchitecture.Core;
using CRUDCleanArchitecture.Infrastructure;

namespace CRUDCleanArchitecture.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection addAppDI(this IServiceCollection services, IConfiguration configuration)
        {
            services.addApplicationDI()
                .addInfrastructureDI()
                .addCoreDI(configuration);

            return services;
        }
    }
}
