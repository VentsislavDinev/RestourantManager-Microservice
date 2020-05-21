using Abp.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using Service.Products.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Products.EntityFramework
{
    public class ProductDbContext : AbpDbContext
    {
        public DbSet<Kitchen> Kitchens { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<WaitList> WaitList { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Product> Products { get; set; }

        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
