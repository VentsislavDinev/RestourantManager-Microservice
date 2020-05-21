using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Orchistrator.Employee.Internal.Service
{
    public class EmployeeModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EmployeeModule).GetAssembly());
        }
    }
}
