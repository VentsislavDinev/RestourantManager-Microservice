using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Employee.Abstract
{
    public class AbstractModule : AbpModule
    {

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbstractModule).GetAssembly());
        }
    }
}
