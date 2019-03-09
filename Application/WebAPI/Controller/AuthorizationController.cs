using DataEntities.Core;
using DomainEntities.Login;
using InternalLogicIntefaces.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Controller
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthorizationController : BaseController
    {
        private readonly IAuthorizationInterface _authorization;
        private readonly IConfiguration _config;
        public AuthorizationController(IAuthorizationInterface authorization, IConfiguration config)
        {
            _config = config;
            _authorization = authorization;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegistrationDto registrationDto)
        {
            registrationDto.UserName = registrationDto.UserName.ToLower();

            if (await _authorization.UserExists(registrationDto.UserName))
                return BadRequest("Username already exists");

            var newUser = new User
            {
                UserName = registrationDto.UserName,
                Email = registrationDto.Email
            };

            var createdUser = await _authorization.Register(newUser, registrationDto.Password);

            return StatusCode(201);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
            var loggedUser = await _authorization.Login(loginDto.UserName.ToLower(), loginDto.Password);

            if (loggedUser == null)
                return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, loggedUser.ExternalID.ToString()),
                new Claim(ClaimTypes.Name, loggedUser.UserName)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("AppSetting:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}