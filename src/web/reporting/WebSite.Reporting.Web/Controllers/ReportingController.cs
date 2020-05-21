using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.Reporting.Web.Controllers
{
    public class ReportingController : AbpController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
