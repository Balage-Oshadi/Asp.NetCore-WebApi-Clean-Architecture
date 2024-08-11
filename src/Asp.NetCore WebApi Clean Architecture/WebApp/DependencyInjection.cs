using Application;
using Infrastructure;

namespace WebApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddWebApiDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastructureDI();
            
            return services;
        }
    }
}
