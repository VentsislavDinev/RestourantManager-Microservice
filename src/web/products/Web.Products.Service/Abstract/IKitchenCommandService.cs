using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IKitchenCommandService : IApplicationService
    {
        Task Create(KitchenViewModel model);
        Task Delete(int model);
        Task Update(KitchenViewModel model);
    }
}