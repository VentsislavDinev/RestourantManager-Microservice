﻿using Abp.Modules;
using Abp.Reflection.Extensions;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Payment.Application
{
    public class PaymentModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PaymentModule).GetAssembly());
        }

    }
}
