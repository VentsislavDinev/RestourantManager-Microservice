using Abp.Application.Services.Dto;

using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Automation.RestourantManager.Model
{
    public class ReservationSortViewModel : IPagedResultRequest
    {
        public int SkipCount { get; set; }
        public int MaxResultCount { get; set; }
    }
}
