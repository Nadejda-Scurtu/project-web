using System.ComponentModel.DataAnnotations;

namespace WebAplication.Models
{
    public class UserLoginForm
    {
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(8, ErrorMessage = "Password must be more than 8 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum surname length 50 characters.")]
        public string Password { get; set; }

        public bool RememberPassword { get; set;}
    }
}