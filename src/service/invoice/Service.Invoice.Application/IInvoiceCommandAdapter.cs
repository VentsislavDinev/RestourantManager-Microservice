using Abp.Application.Services;

using Domain.Invoice.Model;

namespace Service.Invoice.Application
{
    [RemoteService(IsEnabled = false)]
    public interface IInvoiceCommandAdapter : IApplicationService
    {
        Model.Invoice CreateUpdate(InvoiceEntity model);
    }
}