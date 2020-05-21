using Abp.Application.Services.Dto;
using Abp.Domain.Values;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class AllWaitListsViewModel
    {
        public IImmutableList<WaitListViewModel> WaitListDtos { get; set;  }
    }
}
