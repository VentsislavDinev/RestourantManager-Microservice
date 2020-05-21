using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;

using Service.Products.EntityFramework;

namespace Restourant.Manager.EntityFrameworkCore
{
    [DependsOn(
        typeof(ManagerCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ManagerEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<ProductDbContext>(options =>
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

        public override void PostInitialize()
        {
        }
    }
}
