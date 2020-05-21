using Abp.Application.Services;

using Domain.Invoice.Model;

using System.Threading.Tasks;

namespace Service.Invoice.Application
{
    public interface IInvoiceCommandService : IApplicationService
    {
        Task Create(InvoiceEntity model);
        Task Delete(int id);
        Task<Model.Invoice> Update(InvoiceEntity model);
    }
}