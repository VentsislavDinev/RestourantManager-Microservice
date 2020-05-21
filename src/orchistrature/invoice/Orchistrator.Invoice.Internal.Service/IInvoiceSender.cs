using Abp.Application.Services;

using Domain.Invoice.Model;

namespace Orchistrator.Invoice.Internal.Service
{
    public interface IInvoiceSender : IApplicationService
    {
        void SendWaitList(InvoiceEntity customer);
    }
}