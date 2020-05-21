﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.Text;


namespace Service.Products.Model
{
    public class WaitList : Entity, IFullAudited, IMustHaveOrganizationUnit
    {
        public WaitList(string title, string image, string description, long? creatorUserId, DateTime creationTime, long? lastModifierUserId, DateTime? lastModificationTime, long? deleterUserId, DateTime? deletionTime, bool isDeleted, long organizationUnitId)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Image = image ?? throw new ArgumentNullException(nameof(image));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CreatorUserId = creatorUserId;
            CreationTime = creationTime;
            LastModifierUserId = lastModifierUserId;
            LastModificationTime = lastModificationTime;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
            IsDeleted = isDeleted;
            OrganizationUnitId = organizationUnitId;
        }
        public WaitList()
        {

        }
        public string Title { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public long OrganizationUnitId { get; set; }
    }
}