using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Restourant.Manager.Authorization.Roles;
using Restourant.Manager.Authorization.Users;
using Restourant.Manager.MultiTenancy;

namespace Restourant.Manager.EntityFrameworkCore
{
    public class ManagerDbContext : AbpZeroDbContext<Tenant, Role, User, ManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ManagerDbContext(DbContextOptions<ManagerDbContext> options)
            : base(options)
        {
        }
    }
}
