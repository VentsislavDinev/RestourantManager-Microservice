using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Restourant.Manager;
using Restourant.Manager.Configuration;
using Web.Payment.Service;

namespace Website.Payment.Web.Startup
{
    [DependsOn(
       typeof(ManagerWebCoreModule), typeof(PaymentModule))]
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
            IocManager.RegisterAssemblyByConvention(typeof(IntuitWebHostModule).GetAssembly());
        }
    }
}
