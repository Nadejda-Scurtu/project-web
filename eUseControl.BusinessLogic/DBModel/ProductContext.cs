using eUseControl.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=TESTTEST") { }

        public virtual DbSet<Product> Products { get; set; }
    }
}
