using eUseControl.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public abstract class ProductService : BaseService
    {
        public static ServiceResponse<Product> Add(Product product)
        {
            DbContext.Products.Add(product);
            DbContext.SaveChanges();
            return Success(product);
        }

        public static ServiceResponse<List<Product>> GetAll()
        {
            return Success(DbContext.Products.ToList());
        }
    }
}
