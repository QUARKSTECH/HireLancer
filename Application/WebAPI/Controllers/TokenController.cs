using AuthProvider.Interface;
using AuthProvider.Model;
using Microsoft.AspNetCore.Mvc;
using System;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        private ITokenProvider _tokenProvider;

        public TokenController(ITokenProvider tokenProvider) // We'll create this later, don't worry.
        {
            _tokenProvider = tokenProvider;
        }

        [HttpGet]
        public JsonWebToken Get([FromQuery] string grant_type, [FromQuery] string username, [FromQuery] string password, [FromQuery] string refresh_token)
        {
            // Authenticate depending on the grant type.
            User user = grant_type == "refresh_token" ? GetUserByToken(refresh_token) : GetUserByCredentials(username, password);

            if (user == null)
                throw new UnauthorizedAccessException("No!");

            int ageInMinutes = 20;  // However long you want...

            DateTime expiry = DateTime.UtcNow.AddMinutes(ageInMinutes);

            var token = new JsonWebToken
            {
                access_token = _tokenProvider.CreateToken(user, expiry),
                expires_in = ageInMinutes * 60
            };

            if (grant_type != "refresh_token")
                token.refresh_token = GenerateRefreshToken(user);

            return token;
        }

        private User GetUserByToken(string refreshToken)
        {
            // TODO: Check token against your database.
            if (refreshToken == "test")
                return new User { UserName = "test" };

            return null;
        }

        private User GetUserByCredentials(string username, string password)
        {
            // TODO: Check username/password against your database.
            if (username == password)
                return new User { UserName = username };

            return null;
        }

        private string GenerateRefreshToken(User user)
        {
            // TODO: Create and persist a refresh token.
            return "test";
        }
    }
}
