using Abp.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Invoice.EntityFramework
{
    public class InvoiceDbContext : AbpDbContext
    {
        public DbSet<Service.Invoice.Model.Invoice> Invoices { get; set; }
        public InvoiceDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
