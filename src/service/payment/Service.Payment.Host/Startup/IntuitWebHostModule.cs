﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Restourant.Manager.Configuration;
using Restourant.Manager;
using Service.Payment.Application;
using Abp.AspNetCore.Configuration;

namespace Service.Payment.Host.Startup
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
            Configuration.Modules.AbpAspNetCore().CreateControllersForAppServices(typeof(PaymentModule).Assembly, moduleName: "app", useConventionalHttpVerbs: true);
            IocManager.RegisterAssemblyByConvention(typeof(IntuitWebHostModule).GetAssembly());
        }
    }
}
