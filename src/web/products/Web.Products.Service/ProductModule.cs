using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Web.Products.Service
{
    public class ProductModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ProductModule).GetAssembly());
        }
    }
}
