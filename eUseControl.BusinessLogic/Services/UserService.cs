using eUseControl.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace eUseControl.BusinessLogic.Services
{
    public class UserService : BaseService
    {
        public ServiceResponse<User> GetById(int id)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.ID == id));
        }

        public ServiceResponse<User> GetByEmail(string email)
        {
            return Success(DbContext.Users.FirstOrDefault(x => x.Email == email));
        }

        public ServiceResponse<List<User>> GetAll()
        {
            return Success(DbContext.Users.ToList());
        }

        public ServiceResponse<User> AddProductToUserCart(User user, Product product)
        {
            DbContext.Products.Attach(product);
            DbContext.Users.Attach(user);

            var strPart = $";{product.Id};";
            if (!user.CartProductIds.Contains(strPart))
            {
                user.CartProductIds += strPart;
                DbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                DbContext.SaveChanges();
            }

            return Success(user);
        }

        public ServiceResponse<User> RemoveProductToUserCart(User user, Product product)
        {
            DbContext.Products.Attach(product);
            DbContext.Users.Attach(user);

            var strPart = $";{product.Id};";
            if (user.CartProductIds.Contains(strPart))
            {
                user.CartProductIds = user.CartProductIds.Replace(strPart, "");
                DbContext.Entry(user).State = System.Data.Entity.EntityState.Modified;
                DbContext.SaveChanges();
            }

            return Success(user);
        }

        public ServiceResponse<List<Product>> GetProductsInCart(User user)
        {
            var prodService = new ProductService();

            var _out = new List<Product>();
            var pMatch = Regex.Match(user.CartProductIds, @";([0-9]+);");
            while(pMatch.Success)
            {
                var sId = pMatch.Groups[1].ToString();
                int.TryParse(sId, out var nId);
                var productRest = prodService.GetById(nId);
                if(productRest.Success)
                {
                    if (productRest.Entry != null)
                    {
                        _out.Add(productRest.Entry);    
                    }
                }

                pMatch = pMatch.NextMatch();
            }

            return Success(_out);
        }
    }
}
