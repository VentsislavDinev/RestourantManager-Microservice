using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IProductCommandService: IApplicationService
    {
        Task Create(ProductsViewModel model);
        Task Delete(int model);
        Task Update(ProductsViewModel model);
    }
}