using System.ComponentModel.DataAnnotations;

namespace DomainEntities.Login
{
    public class RegistrationDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = " Password does not match")]
        public string VerifiedPassword { get; set; }
    }
}
