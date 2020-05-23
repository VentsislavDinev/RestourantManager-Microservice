using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.Invoice.Model
{
    public class Invoice : Entity, IFullAudited, IMustHaveOrganizationUnit
    {
        public Invoice(string companyName, string vat, string phone, string addressCompany, string totalPrice, string tax, int productId, long organizationUnitId, long? creatorUserId, DateTime creationTime, long? lastModifierUserId, DateTime? lastModificationTime, long? deleterUserId, DateTime? deletionTime, bool isDeleted)
        {
            CompanyName = companyName ?? throw new ArgumentNullException(nameof(companyName));
            Vat = vat ?? throw new ArgumentNullException(nameof(vat));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            AddressCompany = addressCompany ?? throw new ArgumentNullException(nameof(addressCompany));
            TotalPrice = totalPrice ?? throw new ArgumentNullException(nameof(totalPrice));
            Tax = tax ?? throw new ArgumentNullException(nameof(tax));
            ProductId = productId;
            OrganizationUnitId = organizationUnitId;
            CreatorUserId = creatorUserId;
            CreationTime = creationTime;
            LastModifierUserId = lastModifierUserId;
            LastModificationTime = lastModificationTime;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
            IsDeleted = isDeleted;
        }
        public Invoice()
        {

        }

        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string CompanyName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string Vat { get; set; }
        [Required]
        [StringLength(32, ErrorMessage = "The field is required", MinimumLength = 8)]
        [DataType(DataType.Text)]
        public string Phone { get; set; }
        [Required]
        [StringLength(60, ErrorMessage = "The field is required", MinimumLength = 6)]
        [DataType(DataType.Text)]
        public string AddressCompany { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string TotalPrice { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
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
