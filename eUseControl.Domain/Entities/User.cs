using eUseControl.Domain.Enums;
using System;

namespace eUseControl.Domain.Entities
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public URole Level { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public DateTime UpdateRegisterDate { get; set; } = DateTime.Now;
        public DateTime LoginDateTime { get; set; } = DateTime.Now;
        public string LoginIP { get; set; }
        public string CartProductIds { get; set; } = ";0;;1;;2;";
    }
}
