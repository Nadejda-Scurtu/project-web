using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.Products;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() 
            : base("name=WebApplication") { }

        public DbSet<User> Users { get; set; }
        public DbSet<SDbModel> Sessions { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
