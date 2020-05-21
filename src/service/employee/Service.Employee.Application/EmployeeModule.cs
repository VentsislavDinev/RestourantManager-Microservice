using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Employee.Application
{
    public class EmployeeModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EmployeeModule).GetAssembly());
        }


    }
}
