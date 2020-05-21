using Abp.Application.Services;

using Domain.Employee.Model;

using System.Threading.Tasks;

namespace Orchistrator.Employee.Internal.Service
{
    public interface IEmployeeService : IApplicationService
    {
        Task Create(EmployeeEntity model);
        Task Delete(int id);
        Task Update(EmployeeEntity model);
    }
}