using Abp.AspNetCore.Mvc.ViewComponents;

namespace Restourant.Manager.Web.Views
{
    public abstract class ManagerViewComponent : AbpViewComponent
    {
        protected ManagerViewComponent()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }
    }
}
