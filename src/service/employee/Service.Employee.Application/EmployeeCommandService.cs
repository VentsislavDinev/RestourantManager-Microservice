using Abp.Application.Services;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Organizations;

using Domain.Employee.Model;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Employee.Application
{
    public class EmployeeCommandService : ApplicationService, IEmployeeCommandService
    {
        private readonly IRepository<Service.Employee.Model.Employee> _employee;
        private readonly IEmployeeAdapter _employeeAdapter;

        public EmployeeCommandService(IRepository<Model.Employee> employee, IEmployeeAdapter employeeAdapter)
        {
            _employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _employeeAdapter = employeeAdapter ?? throw new ArgumentNullException(nameof(employeeAdapter));
        }

        public async Task Create(EmployeeEntity model)
        {
            await _employee.InsertAsync(_employeeAdapter.CreateAndUpdate(model));
        }
        public async Task<Model.Employee> Update(EmployeeEntity model)
        {
            return await _employee.UpdateAsync(_employeeAdapter.CreateAndUpdate(model));
        }

        public async Task Delete(int id)
        {
            await _employee.DeleteAsync(id);
        }
    }
}
