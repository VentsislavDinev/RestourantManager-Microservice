using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IKitchenCommandService : IApplicationService
    {
        Task Create(KitchenDto model);
        Task Delete(int id);
        Task Update(KitchenDto model);
    }
}