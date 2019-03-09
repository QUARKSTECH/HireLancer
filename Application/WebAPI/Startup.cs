using Extensions.DbContext;
using Extensions.Mapper;
using Extensions.Swagger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(config =>
            {
                config.ReturnHttpNotAcceptable = true;
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Add framework services.
            services.AddContext(Configuration);

            // Register the Swagger generator
            services.AddSwaggerDocumentation();

            // Add cors
            services.AddCors();

            // Add Mapper
            services.AddMapper();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Authenticate
            services.AddJWTAuthentication(Configuration);
        }

        // TODO: Check for development
        //public void ConfigureDevelopmentServices(IServiceCollection services)
        //{

        //}

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseStaticFiles();
            app.UseCookiePolicy();
           

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwaggerDocumentation();

            // Add migraation and seed
            app.AddMigrationAndSeed();

            //app.UseMvc(routes => {
            //    routes.MapSpaFallbackRoute(
            //        name: "spa-fallback",
            //        defaults: new { Controller = "Base", action = "Index" }
            //    );
            //});

            app.UseMvc();
        }
    }
}
