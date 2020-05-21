using Abp.Application.Services;

using Domain.Employee.Model;

namespace Orchistrator.Employee.Internal.Service
{
    public interface IEmployeeSender : IApplicationService
    {
        void SendCustomer(EmployeeEntity customer);
    }
}