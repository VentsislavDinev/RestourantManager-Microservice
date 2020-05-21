using Abp.Application.Services;

using System.Threading.Tasks;

using WiLSoft.Automation.RestourantManager.Module;

namespace WiLSoft.Automation.RestourantManager
{
    public interface IProductCommandService : IApplicationService
    {
        Task Create(ProductsDto model);
        Task Delete(int id);
        Task Update(ProductsDto model);
    }
}