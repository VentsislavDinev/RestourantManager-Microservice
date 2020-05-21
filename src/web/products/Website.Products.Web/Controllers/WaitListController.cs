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
    public class WaitListController : AbpController
    {
        private readonly IWaitListCommandService _waitList;
        private readonly IWaitListQueryService _waitListQueryService;

        public WaitListController(IWaitListCommandService waitList, IWaitListQueryService waitListQueryService)
        {
            _waitList = waitList ?? throw new ArgumentNullException(nameof(waitList));
            _waitListQueryService = waitListQueryService ?? throw new ArgumentNullException(nameof(waitListQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _waitListQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _waitListQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _waitListQueryService.Get(id));
        }

        public async Task<IActionResult> Update(WaitListViewModel model)
        {
            await _waitList.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _waitListQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _waitList.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(WaitListViewModel model)
        {
            await _waitList.Create(model);
            return Redirect("/");
        }
    }
}
