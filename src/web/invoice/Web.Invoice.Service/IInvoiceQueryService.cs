using Abp.Application.Services;
using Abp.Application.Services.Dto;

using System.Threading.Tasks;

using Web.Invoice.Service.ViewModel;

namespace Web.Invoice.Service
{
    public interface IInvoiceQueryService : IApplicationService
    {
        Task<InvoiceViewModel> Get(int model);
        Task<PagedResultDto<InvoiceViewModel>> GetAll();
    }
}