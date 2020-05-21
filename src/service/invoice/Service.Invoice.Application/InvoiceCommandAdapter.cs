using Abp.Application.Services;

using Domain.Invoice.Model;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Invoice.Application
{
    public class InvoiceCommandAdapter : ApplicationService, IInvoiceCommandAdapter
    {
        public Model.Invoice CreateUpdate(InvoiceEntity model)
        {
            return new Model.Invoice(model.CompanyName, model.Vat, model.Phone, model.AddressCompany, model.TotalPrice, model.Tax, model.ProductId, model.OrganizationUnitId, model.CreatorUserId, model.CreationTime, model.LastModifierUserId, model.LastModificationTime, model.DeleterUserId, model.DeletionTime, model.IsDeleted);
        }
    }
}
