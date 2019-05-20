using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        [MinLength(8, ErrorMessage = "Password must be longer than 8 characters.")]
        public string Password { get; set; }
    }
}