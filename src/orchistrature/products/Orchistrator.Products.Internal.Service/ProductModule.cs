using Abp.Modules;
using Abp.Reflection.Extensions;

using Domain.Products.Abstract;

using System;
using System.Collections.Generic;
using System.Text;

namespace Orchistrator.Products.Internal.Service
{
    [DependsOn(typeof(AbstractModule))]
    public class ProductOrchistratorModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductOrchistratorModule).GetAssembly());
        }

    }
}
