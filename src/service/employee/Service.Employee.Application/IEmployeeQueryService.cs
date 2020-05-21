using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Employee.Model;

using System.Threading.Tasks;

namespace Service.Employee.Application
{
    public interface IEmployeeQueryService : IApplicationService
    {
        Task<EmployeeEntity> Get(int model);
        Task<PagedResultDto<EmployeeEntity>> GetAll(EmployeeSortDto model);
    }
}