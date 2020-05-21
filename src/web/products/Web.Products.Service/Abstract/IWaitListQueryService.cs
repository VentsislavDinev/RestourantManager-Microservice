using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IWaitListQueryService : IApplicationService
    {
        Task<TableViewModel> Get(int model);
        Task<PagedResultDto<TableViewModel>> GetAll();
    }
}