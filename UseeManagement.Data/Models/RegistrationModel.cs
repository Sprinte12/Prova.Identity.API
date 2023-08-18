using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Data.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "User name is required")]
        public required string Username { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public required string FirstName { get; set; }
        public required string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public required string Password { get; set; }
    }
}
