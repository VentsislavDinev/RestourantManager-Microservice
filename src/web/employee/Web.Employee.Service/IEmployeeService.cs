using Abp.Application.Services;

using System.Threading.Tasks;

using Web.Employee.Service.ViewModel;

namespace Web.Employee.Service
{
    public interface IEmployeeService : IApplicationService
    {
        Task Create(EmployeeViewModel model);
        Task Delete(int id);
        Task Update(EmployeeViewModel model);
    }
}