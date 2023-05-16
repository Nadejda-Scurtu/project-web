using eUseControl.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public abstract class UserService : BaseService
    {
        public static ServiceResponse<User> GetById(int id)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.ID == id));
        }

        public static ServiceResponse<User> GetByEmail(string email)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.Email == email));
        }

        public ServiceResponse<List<User>> GetAll()
        {
            return Success(DbContext.Users.ToList());
        }
    }
}
