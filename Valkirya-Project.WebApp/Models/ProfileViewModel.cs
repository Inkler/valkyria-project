using System.ComponentModel.DataAnnotations;

namespace Valkirya_Project.WebApp.Models
{
    public class ProfileViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, ErrorMessage = "Username cannot be longer than 15 characters")]
        [RegularExpression("[a-zA-Z0-9]*", ErrorMessage = "username can only contain a-z A-Z characters and 0-9 numbers")]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
