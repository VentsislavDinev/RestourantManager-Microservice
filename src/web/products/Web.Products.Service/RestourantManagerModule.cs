using Abp.Modules;
using Abp.Reflection.Extensions;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;


namespace WiLSoft.Automation.RestourantManager
{
    [DependsOn(typeof(AbstractModule))]
    public class RestourantManagerModule : AbpModule
    {


        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbstractModule).GetAssembly());
        }
    }
}
