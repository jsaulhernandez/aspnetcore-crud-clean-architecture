using CRUDCleanArchitecture.Core.Interfaces;
using CRUDCleanArchitecture.Core.Options;
using CRUDCleanArchitecture.Infrastructure.Data;
using CRUDCleanArchitecture.Infrastructure.Repositories;
using CRUDCleanArchitecture.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace CRUDCleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection addInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>((provider, options) =>
            {
                options.UseSqlServer(provider.GetRequiredService<IOptionsSnapshot<ConnectionStringOptions>>().Value.DefaultConnection); 
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.AddHttpClient<ICoindeskHttpClientService, CoindeskHttpClientService>((provider, options) =>
            {
                options.BaseAddress = new Uri(provider.GetRequiredService<IOptionsMonitor<ConnectionStringOptions>>().CurrentValue.CoindeskConnection);
            });

            services.AddScoped<IExternalVendorRepository, ExternalVendorRepository>();

            return services;
        }
    }
}
