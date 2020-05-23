using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        [Required]
        [StringLength(10000, ErrorMessage = "The field is required", MinimumLength = 7)]
        [DataType(DataType.ImageUrl)]
        [RegularExpression(@"^((http|ftp|https|www)://)?([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$")]
        public string Image { get; set; }
        [Required]
        [StringLength(10000, ErrorMessage = "The field is required", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
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
