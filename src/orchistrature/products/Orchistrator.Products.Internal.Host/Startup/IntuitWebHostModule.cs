using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Restourant.Manager.Configuration;
using Restourant.Manager;
using Abp.AspNetCore.Configuration;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Orchistrator.Products.Internal.Service;

namespace Orchistrator.Products.Internal.Host.Startup
{
    [DependsOn(
       typeof(ManagerWebCoreModule), typeof(ProductOrchistratorModule))]
    public class IntuitWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public IntuitWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(ProductOrchistratorModule).Assembly, moduleName: "app", useConventionalHttpVerbs: true);

            IocManager.RegisterAssemblyByConvention(typeof(IntuitWebHostModule).GetAssembly());
        }
    }
}
