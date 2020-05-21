using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Employee.Model;

using System.Threading.Tasks;

namespace Orchistrator.Employee.Internal.Service
{
    public interface IEmployeeQueryService : IApplicationService
    {
        Task<EmployeeEntity> Get(int model);
        Task<PagedResultDto<EmployeeEntity>> GetAll();
    }
}