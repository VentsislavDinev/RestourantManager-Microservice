using Abp.Application.Services;

using Domain.Employee.Model;

namespace Service.Employee.Application
{
    [RemoteService(IsEnabled = false)]
    public interface IEmployeeAdapter : IApplicationService
    {
        Model.Employee CreateAndUpdate(EmployeeEntity model);
    }
}