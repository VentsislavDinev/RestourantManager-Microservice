using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Restourant.Manager.Controllers
{
    public abstract class ManagerControllerBase: AbpController
    {
        protected ManagerControllerBase()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
