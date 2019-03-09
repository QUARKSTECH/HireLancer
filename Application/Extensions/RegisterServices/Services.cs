using BussinessLogicInterfaces;
using BussinessLogicInterfaces.Core;
using BussinessLogicServices;
using BussinessLogicServices.Core;
using DataEntities.HelperField;
using FacadeLayer.Interfaces;
using FacadeLayer.Services;
using InternalLogicIntefaces.Authorization;
using InternalLogicIntefaces.GenericRepository;
using InternalLogicIntefaces.Mapping;
using InternalLogicIntefaces.Persistence;
using InternalLogicIntefaces.UnitOfWork;
using InternalLogicServices.GenericRepository;
using InternalLogicServices.Mapping;
using InternalLogicServices.Persistence;
using InternalLogicServices.UOW;
using Microsoft.Extensions.DependencyInjection;
using WebAPI.Authentication;

namespace Extensions.RegisterServices
{
    internal static class Services
    {
        internal static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            // TODO: Moin, Unit of work should used as singleton
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IGenericRepository<HelperFields>, GenericRepository<HelperFields>>();
            services.AddScoped<IPersistence, PersistenceService>();
            services.AddScoped<IKernel, Kernel>();
            services.AddScoped<IMapperService, MapperService>();
            services.AddScoped<IServiceInterface, ServiceBase>();
            services.AddScoped<IAuthorizationInterface, AuthorizationService>();

            // Module services
            services.AddScoped<IProServiceInterface, ProServiceService>();
            services.AddScoped<IStartUpInterface, StartUpService>();

            return services;
        }
    }
}
