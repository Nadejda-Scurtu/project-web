using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace WebAplication.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "This field is required.")]
        [Display(Name = "Email adress")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [MinLength(8, ErrorMessage = "Password must be more than 8 characters.")]
        [MaxLength(50, ErrorMessage = "Maximum surname length 50 characters.")]
        public string Password { get; set; }

        // Remember
        [Display(Name = "Save Password?")]
        public bool Remember { get; set;}
    }
}