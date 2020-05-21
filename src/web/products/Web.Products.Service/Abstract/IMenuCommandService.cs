using Abp.Application.Services;

using System.Threading.Tasks;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IMenuCommandService : IApplicationService
    {
        Task Create(MenuViewModel model);
        Task Delete(int model);
        Task Update(MenuViewModel model);
    }
}