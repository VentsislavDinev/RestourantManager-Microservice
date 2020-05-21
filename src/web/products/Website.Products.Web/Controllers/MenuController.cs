using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

using WiLSoft.Automation.RestourantManager;

namespace Website.Products.Web.Controllers
{
    public class MenuController : AbpController
    {
        private readonly IMenuCommandService _menu;
        private readonly IMenuQueryService _menuQueryService;

        public MenuController(IMenuCommandService menu, IMenuQueryService menuQueryService)
        {
            _menu = menu ?? throw new ArgumentNullException(nameof(menu));
            _menuQueryService = menuQueryService ?? throw new ArgumentNullException(nameof(menuQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _menuQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _menuQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _menuQueryService.Get(id));
        }

        public async Task<IActionResult> Update(MenuViewModel model)
        {
            await _menu.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _menuQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _menu.Delete(id);
            return Redirect("/");
        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(MenuViewModel model)
        {
            await _menu.Create(model);
            return Redirect("/");
        }
    }
}
