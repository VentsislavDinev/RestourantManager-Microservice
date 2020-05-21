using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

using WiLSoft.Automation.RestourantManager;
using WiLSoft.Automation.RestourantManager.Module;

namespace Website.Products.Web.Controllers
{
    public class TableController : AbpController
    {
        private readonly ITableCommandService _table;
        private readonly ITableQueryService _tableQueryService;

        public TableController(ITableCommandService table, ITableQueryService tableQueryService)
        {
            _table = table ?? throw new ArgumentNullException(nameof(table));
            _tableQueryService = tableQueryService ?? throw new ArgumentNullException(nameof(tableQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _tableQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _tableQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _tableQueryService.Get(id));
        }

        public async Task<IActionResult> Update(TableViewModel model)
        {
            await _table.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _tableQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _table.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(TableViewModel model)
        {
            await _table.Create(model);
            return Redirect("/");
        }
    }
}
