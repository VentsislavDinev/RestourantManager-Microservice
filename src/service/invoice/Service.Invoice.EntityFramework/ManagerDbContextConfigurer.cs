using System.Data.Common;
using Microsoft.EntityFrameworkCore;

using Service.Invoice.EntityFramework;

namespace Restourant.Manager.EntityFrameworkCore
{
    public static class ManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<InvoiceDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<InvoiceDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
