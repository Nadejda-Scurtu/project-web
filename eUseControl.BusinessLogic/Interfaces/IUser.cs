using eUseControl.Domain.Entities.Products;
using eUseControl.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eUseControl.Domain.Entities.Response;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface IUser
    {
        User GetUserById(int id);
        List<User> GetUserList();
        List<Product> GetUserCartProducts(int id);
        ServiceResponse ValidateEditUser(User user);
        ServiceResponse ValidateDeleteUser(User user);
    }
}
