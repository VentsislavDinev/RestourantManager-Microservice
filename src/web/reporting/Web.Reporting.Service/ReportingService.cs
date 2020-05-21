using Abp.Application.Services;

using System;
using System.Collections.Generic;
using System.Text;

using Web.Reporting.Service.ViewModel;

namespace Web.Reporting.Service
{
    public class ReportingService : ApplicationService, IReportingService
    {

        public System.Threading.Tasks.Task Create(ReportingViewModel model)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(ReportingViewModel model)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Update(ReportingViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
