using Abp.Application.Services;

using Service.Products.Model;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application.Adapters
{
    [RemoteService(IsEnabled = false)]
    public interface ITableAdapterCommandService : IApplicationService
    {
        Table CreateUpdate(TableDto model);
    }
}