using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderApprovalRequest
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int? RoleId { get; set; }
        public int? ApprovalOwnerId { get; set; }
        public int? RespondedById { get; set; }
        public string Response { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? PermissionId { get; set; }

        public virtual User ApprovalOwner { get; set; }
        public virtual OrderMaster Order { get; set; }
        public virtual User RespondedBy { get; set; }
        public virtual Role Role { get; set; }
    }
}
