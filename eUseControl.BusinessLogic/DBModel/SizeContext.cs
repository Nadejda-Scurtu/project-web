using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.BusinessLogic.DBModel
{
    public class SizeContext : DbContext
    {
        public SizeContext() : base("name=TESTTEST") { }

        public DbSet<Size> Sizes { get; set; }
    }
}
