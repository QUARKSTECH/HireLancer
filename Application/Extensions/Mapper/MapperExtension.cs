using AutoMapper;
using Extensions.RegisterServices;
using Microsoft.Extensions.DependencyInjection;

namespace Extensions.Mapper
{
    public static class MapperExtension
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            // AutoMapper 
            services.AddAutoMapper();

            // Register all services 
            services = services.RegisterServices();

            // Map custom 
            //services = services.AddMapDtoToEntity();
            return services;
        }
    }
}
