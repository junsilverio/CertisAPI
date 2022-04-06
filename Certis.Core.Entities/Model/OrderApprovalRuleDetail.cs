using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderApprovalRuleDetail
    {
        public int Id { get; set; }
        public int ApprovalRuleId { get; set; }
        public int? RoleId { get; set; }
        public int? OwnerId { get; set; }
        public bool RequiredAlert { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
