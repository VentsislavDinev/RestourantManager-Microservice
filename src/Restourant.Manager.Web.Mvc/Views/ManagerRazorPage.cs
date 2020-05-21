using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Restourant.Manager.Web.Views
{
    public abstract class ManagerRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ManagerRazorPage()
        {
            LocalizationSourceName = ManagerConsts.LocalizationSourceName;
        }
    }
}
