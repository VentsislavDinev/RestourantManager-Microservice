using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IProductQueryService : IApplicationService
    {
        Task<ProductsDto> Get(int model);
        Task<PagedResultDto<ProductsDto>> GetAll();
    }
}