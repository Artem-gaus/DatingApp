using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.ModelDTOs
{
    public class UserForRegisterDTO
    {
        [Required]
        public string Username { get; set; }
        [Required]   
        public string Password { get; set; }
    }
}