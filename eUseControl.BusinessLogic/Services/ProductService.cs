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

        public static ServiceResponse<Product> Edit(Product product)
        {
            DbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
            DbContext.SaveChanges();
            return Success(product);
        }

        public static ServiceResponse<List<Product>> GetAll()
        {
            var entries = DbContext.Products
                .ToList();

            return Success(entries);
        }

        public static ServiceResponse<Product> GetById(int id)
        {
            var entry = DbContext.Products
                .FirstOrDefault(x => x.Id == id);

            return Success(entry);
        }
    }
}
