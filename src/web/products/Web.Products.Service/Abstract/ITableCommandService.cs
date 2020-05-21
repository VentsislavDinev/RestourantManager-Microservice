using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface ITableCommandService : IApplicationService
    {
        Task Create(TableViewModel model);
        Task Delete(int model);
        Task Update(TableViewModel model);
    }
}