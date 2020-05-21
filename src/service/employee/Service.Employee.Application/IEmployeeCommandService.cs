using Abp.Application.Services;

using Domain.Employee.Model;

using System.Threading.Tasks;

namespace Service.Employee.Application
{
    public interface IEmployeeCommandService : IApplicationService
    {
        Task Create(EmployeeEntity model);
        Task Delete(int id);
        Task<Model.Employee> Update(EmployeeEntity model);
    }
}