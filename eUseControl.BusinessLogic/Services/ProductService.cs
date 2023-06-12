using eUseControl.Domain.Entities.Products;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace eUseControl.BusinessLogic.Services
{
    public class ProductService : BaseService
    {
        public ServiceResponse<Product> Add(Product product)
        {
            DbContext.Products.Add(product);
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<Product> Edit(Product product)
        {
            DbContext.Entry(product).State = EntityState.Modified;
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<Product> Delete(Product product)
        {
            DbContext.Entry(product).State = EntityState.Deleted;
            DbContext.SaveChanges();
            return Success(product);
        }

        public ServiceResponse<List<Product>> GetAll()
        {
            var entries = DbContext.Products
                .ToList();

            return Success(entries);
        }

        public ServiceResponse<Product> GetById(int id)
        {
            var entry = DbContext.Products
                .FirstOrDefault(x => x.Id == id);

            return Success(entry);
        }
    }
}
