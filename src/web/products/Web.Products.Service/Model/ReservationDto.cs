using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Automation.RestourantManager.Module
{
    public class ReservationViewModel : IFullAudited, ISoftDelete
    {
        public string Title { get; set; }
        public string PhoneNumber { get; set; }
        public string People { get; set; }

        public string ReservationDate { get; set; }

        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public long? CreatorUserId { get; set; }
        public long? LastModifierUserId { get; set; }
        public DateTime? LastModificationTime { get; set; }
        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
