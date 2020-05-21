using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IKitchenQueryService : IApplicationService
    {
        Task<KitchenViewModel> Get(int model);
        Task<PagedResultDto<KitchenViewModel>> GetAll();
    }
}