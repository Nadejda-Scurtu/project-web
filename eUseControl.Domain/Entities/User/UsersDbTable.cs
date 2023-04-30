using eUseControl.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Domain.Entities.User
{
    public class UsersDbTable
    {
        // User ID
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        // UserName
        [
            Display(Name = "Name"),
            Required(ErrorMessage = "This field is required."),
            MinLength(5, ErrorMessage = "Name must be more than 5 characters."),
            MaxLength(20, ErrorMessage = "Maximum name length 20 characters.")
        ]
        public string Name { get; set; }

        // User Surname
        [
            Display(Name = "Surname"),
            Required(ErrorMessage = "This field is required."),
            MinLength(5, ErrorMessage = "Surname must be more than 5 characters."),
            MaxLength(30, ErrorMessage = "Maximum surname length 30 characters.")
        ]
        public string Surname { get; set; }

        // User Email
        [
            Display(Name = "Email adress"),
            Required(ErrorMessage = "This field is required."),
            DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid email.")
        ]
        public string Email { get; set; }

        // Password
        [
            Display(Name = "Password"),
            Required(ErrorMessage = "This field is required."),
            MinLength(8, ErrorMessage = "Password must be more than 8 characters."),
            MaxLength(50, ErrorMessage = "Maximum surname length 50 characters."),
            DataType(DataType.Password)
        ]
        public string Password { get; set; }

        // User Role
        public URole Level { get; set; }

        // RegisterDate
        [DataType(DataType.Date)]
        public DateTime RegisterDate { get; set; }

        // Update RegisterDate
        [DataType(DataType.Date)]
        public DateTime UpdateRegisterDate { get; set; }

        // Login DateTime
        [DataType(DataType.DateTime)]
        public Nullable<DateTime> LoginDateTime { get; set; }

        // LoginIP
        [StringLength(30)]
        public string LoginIP { get; set; }

    }
}
