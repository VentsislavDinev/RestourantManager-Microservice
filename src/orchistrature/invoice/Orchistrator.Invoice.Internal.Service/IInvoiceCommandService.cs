using Abp.Application.Services;

using Domain.Invoice.Model;

using System.Threading.Tasks;

namespace Orchistrator.Invoice.Internal.Service
{
    public interface IInvoiceCommandService : IApplicationService
    {
        Task Create(InvoiceEntity model);
        Task Delete(int id);
        Task Update(InvoiceEntity model);
    }
}