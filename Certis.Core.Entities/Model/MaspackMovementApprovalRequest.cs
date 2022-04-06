using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MaspackMovementApprovalRequest
    {
        public int Id { get; set; }
        public long? MaspackingListId { get; set; }
        public int? ApprovalRuleId { get; set; }
        public int? RequestOwner { get; set; }
        public int? RejectOwner { get; set; }
        public DateTime? RequestedDt { get; set; }
        public bool? IsValid { get; set; }
    }
}
