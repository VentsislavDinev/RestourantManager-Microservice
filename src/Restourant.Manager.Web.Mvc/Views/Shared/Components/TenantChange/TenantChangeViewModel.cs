using Abp.AutoMapper;
using Restourant.Manager.Sessions.Dto;

namespace Restourant.Manager.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
