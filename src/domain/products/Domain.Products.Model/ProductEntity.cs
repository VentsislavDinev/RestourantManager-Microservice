using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Reflection.Metadata;
using System.Text;

namespace WiLSoft.Automation.Domain.Models
{
    public class ProductEntity : EntityDto, IFullAudited, ISoftDelete, IMustHaveOrganizationUnit
    {
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
