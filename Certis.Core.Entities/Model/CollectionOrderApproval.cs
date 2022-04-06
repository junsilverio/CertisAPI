using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CollectionOrderApproval
    {
        public int Id { get; set; }
        public int? CollectionId { get; set; }
        public int? OwnerRole { get; set; }
        public int? OwnerId { get; set; }
        public string Status { get; set; }
        public bool? IsDeleted { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? PermissionId { get; set; }

        public virtual CollectionOrderMaster Collection { get; set; }
        public virtual Role OwnerRoleNavigation { get; set; }
    }
}
