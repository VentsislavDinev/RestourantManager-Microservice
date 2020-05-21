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
    public class ProductController : AbpController
    {
        private readonly IProductCommandService _product;
        private readonly IProductQueryService _productQueryService;

        public ProductController(IProductCommandService product, IProductQueryService productQueryService)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            _productQueryService = productQueryService ?? throw new ArgumentNullException(nameof(productQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _productQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _productQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _productQueryService.Get(id));
        }

        public async Task<IActionResult> Update(ProductsViewModel model)
        {
            await _product.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _productQueryService.Get(id));
        }

        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _product.Delete(id);
            return Redirect("/");
        }

        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> Create(ProductsViewModel model)
        {
            await _product.Create(model);
            return Redirect("/");
        }
    }
}
