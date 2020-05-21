using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Invoice.Model
{
    public class InvoiceEntity : IFullAudited,  IMustHaveOrganizationUnit
    {
        public string CompanyName { get; set; }
        public string Vat { get; set; }
        public string Phone { get; set; }
        public string AddressCompany { get; set; }
        public string TotalPrice { get; set; }
        public string Tax { get; set; }
        public int ProductId { get; set; }
        public long OrganizationUnitId { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
