using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace WiLSoft.Automation.Domain.Models
{
    public class ProductEntity : IFullAudited, ISoftDelete, IMustHaveOrganizationUnit
    {
        public string Title { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public long OrganizationUnitId { get; set; }
    }
}
