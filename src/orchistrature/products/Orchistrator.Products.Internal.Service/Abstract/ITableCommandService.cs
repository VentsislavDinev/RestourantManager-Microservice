using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface ITableCommandService : IApplicationService
    {
        Task Create(TableDto model);
        Task Delete(int id);
        Task Update(TableDto model);
    }
}