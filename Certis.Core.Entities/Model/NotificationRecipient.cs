using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class NotificationRecipient
    {
        public int Id { get; set; }
        public int? NotoficationGroupId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public string Recipient { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
    }
}
