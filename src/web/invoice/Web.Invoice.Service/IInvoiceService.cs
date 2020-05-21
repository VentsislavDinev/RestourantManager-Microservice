using Abp.Application.Services;

using System.Threading.Tasks;

using Web.Invoice.Service.ViewModel;

namespace Web.Invoice.Service
{
    public interface IInvoiceService : IApplicationService
    {
        Task Create(InvoiceViewModel model);
        Task Delete(int id);
        Task Update(InvoiceViewModel model);
    }
}