using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IMenuQueryService : IApplicationService
    {
        Task<MenuViewModel> Get(int model);
        Task<PagedResultDto<MenuViewModel>> GetAll();
    }
}