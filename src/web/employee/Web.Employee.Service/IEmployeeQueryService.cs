using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using Web.Employee.Service.ViewModel;

namespace Web.Employee.Service
{
    public interface IEmployeeQueryService : IApplicationService
    {
        Task<EmployeeViewModel> Get(int model);
        Task<PagedResultDto<EmployeeViewModel>> GetAll();
    }
}