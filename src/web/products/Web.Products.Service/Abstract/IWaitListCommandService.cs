using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IWaitListCommandService: IApplicationService
    {
        Task Create(WaitListViewModel model);
        Task Delete(int model);
        Task Update(WaitListViewModel model);
    }
}