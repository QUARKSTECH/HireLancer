using CommonObjects;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace WebAPI.Extensions
{
    public static class ExceptionHandlerExtensions
    {
        public static void UseCustomExceptionHandler(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.StatusCode = 500;
                    context.Response.ContentType = "application/json";

                    var error = context.Features.Get<IExceptionHandlerFeature>();
                    if (error != null)
                    {
                        var ex = error.Error;

                        await context.Response.WriteAsync(new ExceptionModel()
                        {
                            StatusCode = 500,
                            ErrorMessage = ex.Message
                        }.ToString()); //ToString() is overridden to Serialize object
                    }
                });
            });
        }
    }
}