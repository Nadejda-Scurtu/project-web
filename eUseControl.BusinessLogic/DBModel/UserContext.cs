﻿using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.Products;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=TESTTEST") { }

        public DbSet<User> Users { get; set; }
    }
}
