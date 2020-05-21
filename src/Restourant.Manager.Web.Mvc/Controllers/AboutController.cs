using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Restourant.Manager.Controllers;

namespace Restourant.Manager.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ManagerControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
