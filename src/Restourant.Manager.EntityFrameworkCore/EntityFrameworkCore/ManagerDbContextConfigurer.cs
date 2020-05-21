using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Restourant.Manager.EntityFrameworkCore
{
    public static class ManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ManagerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ManagerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
