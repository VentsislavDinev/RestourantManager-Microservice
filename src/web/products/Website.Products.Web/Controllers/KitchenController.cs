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
    public class KitchenController : AbpController
    {
        private readonly IKitchenCommandService _kitchen;
        private readonly IKitchenQueryService _kitchenQueryService;

        public KitchenController(IKitchenCommandService kitchen, IKitchenQueryService kitchenQueryService)
        {
            _kitchen = kitchen ?? throw new ArgumentNullException(nameof(kitchen));
            _kitchenQueryService = kitchenQueryService ?? throw new ArgumentNullException(nameof(kitchenQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _kitchenQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _kitchenQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _kitchenQueryService.Get(id));
        }

        public async Task<IActionResult> Update(KitchenViewModel model)
        {
            await _kitchen.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _kitchenQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _kitchen.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(KitchenViewModel model)
        {
            await _kitchen.Create(model);
            return Redirect("/");
        }
    }
}
