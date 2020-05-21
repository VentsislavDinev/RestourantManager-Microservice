using Abp.Application.Services;
using Restourant.Manager.MultiTenancy.Dto;

namespace Restourant.Manager.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

