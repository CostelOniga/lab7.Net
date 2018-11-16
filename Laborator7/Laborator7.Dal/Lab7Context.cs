using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator7.Dal
{
    public sealed class Lab7Context : DbContext
    {
        public Lab7Context(DbContextOptions<Lab7Context> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
