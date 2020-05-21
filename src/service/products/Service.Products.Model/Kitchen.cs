using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Products.Model
{
    public class Kitchen : Entity,  IFullAudited, IMustHaveOrganizationUnit
    {
        public Kitchen(string title, string image, string description, long organizationUnitId, bool isDeleted, long? creatorUserId, DateTime creationTime, long? lastModifierUserId, DateTime? lastModificationTime, long? deleterUserId, DateTime? deletionTime)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Image = image ?? throw new ArgumentNullException(nameof(image));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            OrganizationUnitId = organizationUnitId;
            IsDeleted = isDeleted;
            CreatorUserId = creatorUserId;
            CreationTime = creationTime;
            LastModifierUserId = lastModifierUserId;
            LastModificationTime = lastModificationTime;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
        }
        public Kitchen()
        {

        }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public long OrganizationUnitId { get; set; }
        public bool IsDeleted { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
    }
}
