using Database.Context;
using Database.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedObjects;

namespace Extensions.DbContext
{
    public static class ContextExtension
    {
        public static IServiceCollection AddContext(this IServiceCollection services, IConfiguration Configuration)
        {
            // Add framework services.
            services.AddDbContext<ApiContext>(options => options.UseSqlServer(Configuration.GetConnectionString(ConstantDto.ConnectionString)));
            //.AddUnitOfWork<ApiContext>();
            return services;
        }


        public static void AddMigrationAndSeed(this IApplicationBuilder app)
        {
            //Add migration seed changes
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                if (!serviceScope.ServiceProvider.GetService<ApiContext>().AllMigrationsApplied())
                {
                    serviceScope.ServiceProvider.GetService<ApiContext>().Database.Migrate();
                    serviceScope.ServiceProvider.GetService<ApiContext>().EnsureSeeded();
                }
            }
        }
    }
}
