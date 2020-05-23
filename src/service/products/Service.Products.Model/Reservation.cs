using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.Products.Model
{
    public class Reservation : Entity, IFullAudited, IMustHaveOrganizationUnit
    {
        public Reservation()
        {

        }

        public Reservation(string title, string phoneNumber, string people, string reservationDate, string description, DateTime creationTime, long? creatorUserId, long? lastModifierUserId, DateTime? lastModificationTime, long? deleterUserId, DateTime? deletionTime, bool isDeleted, long organizationUnitId)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            People = people ?? throw new ArgumentNullException(nameof(people));
            ReservationDate = reservationDate ?? throw new ArgumentNullException(nameof(reservationDate));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            CreationTime = creationTime;
            CreatorUserId = creatorUserId;
            LastModifierUserId = lastModifierUserId;
            LastModificationTime = lastModificationTime;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
            IsDeleted = isDeleted;
            OrganizationUnitId = organizationUnitId;
        }

        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 10)]
        [DataType(DataType.MultilineText)]
        public string Title { get; set; }
        [Required]
        [StringLength(14, ErrorMessage = "The field is required", MinimumLength = 8)]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(8, ErrorMessage = "The field is required", MinimumLength = 1)]
        public string People { get; set; }
        [Required]
        public string ReservationDate { get; set; }

        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 10)]
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
