using Abp.Application.Services;

using System.Threading.Tasks;

using Web.Reporting.Service.ViewModel;

namespace Web.Reporting.Service
{
    public interface IReportingService : IApplicationService
    {
        Task Create(ReportingViewModel model);
        Task Delete(ReportingViewModel model);
        Task Update(ReportingViewModel model);
    }
}