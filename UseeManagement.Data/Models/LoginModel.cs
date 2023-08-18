

using System.ComponentModel.DataAnnotations;

namespace UserManagement.Data.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User name is required")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Password name is required")]
        public required string Password { get; set; }
    }
}
