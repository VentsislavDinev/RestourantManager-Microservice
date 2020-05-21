using Abp.Application.Services;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Repositories;
using Abp.Organizations;

using Domain.Invoice.Model;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Invoice.Application
{
    public class InvoiceCommandService : ApplicationService, IInvoiceCommandService
    {
        private readonly IRepository<Model.Invoice> _invoice;
        private readonly IInvoiceCommandAdapter _invoiceCommandAdapter;

        public InvoiceCommandService(IRepository<Model.Invoice> invoice, IInvoiceCommandAdapter invoiceCommandAdapter)
        {
            _invoice = invoice ?? throw new ArgumentNullException(nameof(invoice));
            _invoiceCommandAdapter = invoiceCommandAdapter ?? throw new ArgumentNullException(nameof(invoiceCommandAdapter));
        }

        public async Task Create(InvoiceEntity model)
        {
            await _invoice.InsertAsync(_invoiceCommandAdapter.CreateUpdate(model));
        }

        public async Task<Model.Invoice> Update(InvoiceEntity model)
        {
            return await _invoice.UpdateAsync(_invoiceCommandAdapter.CreateUpdate(model));
        }

        public async Task Delete(int id)
        {
            await _invoice.DeleteAsync(id);
        }
    }
}
