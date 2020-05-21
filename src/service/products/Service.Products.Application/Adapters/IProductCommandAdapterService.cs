using Abp.Application.Services;

using Service.Products.Model;

using WiLSoft.Automation.RestourantManager.Module;

namespace Service.Products.Application
{
    [RemoteService(IsEnabled = false)]
    public interface IProductCommandAdapterService : IApplicationService
    {
        Product CreateUpdate(ProductsDto model);
    }
}