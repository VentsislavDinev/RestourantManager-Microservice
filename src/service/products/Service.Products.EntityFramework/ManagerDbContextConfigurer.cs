using System.Data.Common;
using Microsoft.EntityFrameworkCore;

using Service.Products.EntityFramework;

namespace Restourant.Manager.EntityFrameworkCore
{
    public static class ManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ProductDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ProductDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
