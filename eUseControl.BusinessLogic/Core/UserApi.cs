using eUseControl.BusinessLogic.DBModel;
using eUseControl.Domain.Entities.User;
using eUseControl.Domain.Entities.User.Login;
using eUseControl.Domain.Entities.User.Register;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            UsersDbTable result;
            using (var db = new UserContext())
            {
                result = db.Users.FirstOrDefault(u => u.Email == data.Email && u.Password == data.Password);
            }
            if (result == null)
            {
                return new ULoginResp
                {
                    Status = false,
                    StatusMsg = "Email or password are wrong."
                };
            }
            return new ULoginResp { Status = true };
        }
        internal URegisterResp UserRegisterAction(URegisterData data)
        {
            UsersDbTable insert = new UsersDbTable
            {
                Name = data.Name,
                Surname = data.Surname,
                Email = data.Email,
                Password = data.Password,
                Level = Domain.Enums.URole.Admin,
                RegisterDate = DateTime.Now,
                UpdateRegisterDate = DateTime.Now,
            };
            int result;
            using (var db = new UserContext())
            {
                db.Users.Add(insert);
                result = db.SaveChanges();
            }
            if (result == 0)
            {
                return new URegisterResp()
                {
                    Status = false,
                    StatusMsg = "Data can't be saved."
                };
            }
            return new URegisterResp { Status = true };
        }
    }
}
