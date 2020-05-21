using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;

using Service.Invoice.EntityFramework;

namespace Restourant.Manager.EntityFrameworkCore
{
    [DependsOn(
        typeof(ManagerCoreModule), 
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class ManagerEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<InvoiceDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        ManagerDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        ManagerDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ManagerEntityFrameworkModule).GetAssembly());
        }

    }
}
