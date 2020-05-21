using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

using Web.Invoice.Service;
using Web.Invoice.Service.ViewModel;

namespace Website.Invoice.Web.Controllers
{
    public class InvoiceController : AbpController
    {
        private readonly IInvoiceService _invoice;
        private readonly IInvoiceQueryService _invoiceQueryService;

        public InvoiceController(IInvoiceService invoice, IInvoiceQueryService invoiceQueryService)
        {
            _invoice = invoice ?? throw new ArgumentNullException(nameof(invoice));
            _invoiceQueryService = invoiceQueryService ?? throw new ArgumentNullException(nameof(invoiceQueryService));
        }

        public async Task<IActionResult> Index()
        {
            return View(await _invoiceQueryService.GetAll());
        }

        public async Task<IActionResult> GetById(int id)
        {
            return View(await _invoiceQueryService.Get(id));
        }

        public async Task<IActionResult> Update(int id)
        {
            return View(await _invoiceQueryService.Get(id));
        }

        public async Task<IActionResult> Update(InvoiceViewModel model)
        {
            await _invoice.Update(model);
            return Redirect("/");
        }

        public async Task<IActionResult> Delete(int id)
        {
            return View(await _invoiceQueryService.Get(id));
        }
        public async Task<IActionResult> ConfirmDelete(int id)
        {
            await _invoice.Delete(id);
            return Redirect("/");
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Create(InvoiceViewModel model)
        {
            await _invoice.Create(model);
            return Redirect("/");
        }
    }
}
