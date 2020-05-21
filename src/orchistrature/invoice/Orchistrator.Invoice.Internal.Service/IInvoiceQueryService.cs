using Abp.Application.Services;
using Abp.Application.Services.Dto;

using Domain.Invoice.Model;

using System.Threading.Tasks;

namespace Orchistrator.Invoice.Internal.Service
{
    public interface IInvoiceQueryService : IApplicationService
    {
        Task<InvoiceEntity> Get(int model);
        Task<PagedResultDto<InvoiceEntity>> GetAll();
    }
}