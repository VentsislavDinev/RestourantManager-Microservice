using Abp.Application.Services;

using Service.Products.Model;

using WiLSoft.Automation.RestourantManager;

namespace Service.Products.Application
{
    [RemoteService(IsEnabled = false)]
    public interface IMenuAdapterCommandService : IApplicationService
    {
        Menu CreateUpdate(MenuDto model);
    }
}