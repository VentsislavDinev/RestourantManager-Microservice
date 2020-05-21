using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Website.Payment.Web.Controllers
{
    public class PaymentController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
