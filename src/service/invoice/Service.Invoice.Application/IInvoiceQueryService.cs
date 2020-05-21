using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Invoice.Model;

using System.Threading.Tasks;

namespace Service.Invoice.Application
{
    public interface IInvoiceQueryService : IApplicationService
    {
        Task<InvoiceEntity> Get(int model);
        Task<PagedResultDto<InvoiceEntity>> GetAll(InvoiceSortDto model);
    }
}