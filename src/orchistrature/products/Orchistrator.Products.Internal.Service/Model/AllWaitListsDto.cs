using Abp.Application.Services.Dto;
using Abp.Domain.Values;

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class AllWaitListsDto
    {
        public IImmutableList<WaitListDto> WaitListDtos { get; set;  }
    }
}
