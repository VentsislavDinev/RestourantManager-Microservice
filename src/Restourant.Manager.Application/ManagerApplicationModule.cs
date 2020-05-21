using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Restourant.Manager.Authorization;

namespace Restourant.Manager
{
    [DependsOn(
        typeof(ManagerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ManagerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ManagerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ManagerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
