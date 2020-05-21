using Abp.Application.Services.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Automation.RestourantManager
{
    public class MenuSortDto : IPagedResultRequest
    {
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
