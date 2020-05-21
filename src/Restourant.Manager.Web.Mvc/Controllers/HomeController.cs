using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Restourant.Manager.Controllers;

namespace Restourant.Manager.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
