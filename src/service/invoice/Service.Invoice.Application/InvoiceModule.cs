using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Invoice.Application
{
    public class InvoiceModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(InvoiceModule).GetAssembly());
        }


    }
}
