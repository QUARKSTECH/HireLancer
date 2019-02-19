using AuthProvider.Model;
using Microsoft.IdentityModel.Tokens;
using System;

namespace AuthProvider.Interface
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);

        // TokenValidationParameters is from Microsoft.IdentityModel.Tokens
        TokenValidationParameters GetValidationParameters();
    }
}
