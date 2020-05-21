using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

using Web.Employee.Service;
using Web.Employee.Service.ViewModel;

namespace Website.Employee.Web.Controllers
{
    public class EmployeeController : AbpController
    {
        private readonly IEmployeeService _employee;
        private readonly IEmployeeQueryService _employeeQuery;

        public EmployeeController(IEmployeeService employee, IEmployeeQueryService employeeQuery)
        {
            _employee = employee ?? throw new ArgumentNullException(nameof(employee));
            _employeeQuery = employeeQuery ?? throw new ArgumentNullException(nameof(employeeQuery));
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _employeeQuery.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _employeeQuery.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _employeeQuery.Get(id));
        }

        public async Task<IActionResult> Update(EmployeeViewModel model)
        {
            await _employee.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _employeeQuery.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _employee.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(EmployeeViewModel model)
        {
            await _employee.Create(model);
            return Redirect("/");
        }
    }
}
