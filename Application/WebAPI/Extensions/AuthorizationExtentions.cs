using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;

namespace WebAPI.Extensions
{
    public static class AuthorizationExtentions
    {
        public static void AddJWTAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(auth => {
                auth.DefaultPolicy = new AuthorizationPolicyBuilder()
                    .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                    .RequireAuthenticatedUser()
                    .Build();
            });
        }
    }
}
