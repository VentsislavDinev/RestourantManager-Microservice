using Abp.Application.Services;

using System.Threading.Tasks;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IMenuCommandService : IApplicationService
    {
        Task Create(MenuDto model);
        Task Delete(int id);
        Task Update(MenuDto model);
    }
}