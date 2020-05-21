using Abp.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Employee.EntityFramework
{
    public class EmployeeDbContext : AbpDbContext
    {
        public DbSet<Service.Employee.Model.Employee> Employees { get; set; }
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
