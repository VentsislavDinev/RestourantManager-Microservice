using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Organizations;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Service.Employee.Model
{
    public class Employee : Entity, IFullAudited, ISoftDelete, IMustHaveOrganizationUnit
    {
        public Employee(string name, string lastName, string phoneNumber, string address, string email, string possition, long? creatorUserId, DateTime creationTime, long? lastModifierUserId, DateTime? lastModificationTime, long? deleterUserId, DateTime? deletionTime, bool isDeleted, long organizationUnitId)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            PhoneNumber = phoneNumber ?? throw new ArgumentNullException(nameof(phoneNumber));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Possition = possition ?? throw new ArgumentNullException(nameof(possition));
            CreatorUserId = creatorUserId;
            CreationTime = creationTime;
            LastModifierUserId = lastModifierUserId;
            LastModificationTime = lastModificationTime;
            DeleterUserId = deleterUserId;
            DeletionTime = deletionTime;
            IsDeleted = isDeleted;
            OrganizationUnitId = organizationUnitId;
        }
        public Employee()
        {

        }

        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string LastName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The field is required", MinimumLength = 4)]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Possition { get; set; }
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
