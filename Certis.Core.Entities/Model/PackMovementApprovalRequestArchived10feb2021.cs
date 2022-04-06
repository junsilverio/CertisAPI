using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PackMovementApprovalRequestArchived10feb2021
    {
        public int Id { get; set; }
        public long? PackTrackId { get; set; }
        public int? ApprovalRuleId { get; set; }
        public int? RequestOwner { get; set; }
        public int? RejectOwner { get; set; }
        public DateTime? RequestedDt { get; set; }
        public bool? IsValid { get; set; }
        public string Remarks { get; set; }
        public string Response { get; set; }
        public int? Source { get; set; }
        public int? Destination { get; set; }
        public int? RespondedBy { get; set; }
        public bool? TakenOver { get; set; }
        public int? TakenOverBy { get; set; }
        public string CageNo { get; set; }
        public string CageId { get; set; }
        public DateTime? RespondedDt { get; set; }
        public DateTime? TakenOverDt { get; set; }
        public string SecurityStatus { get; set; }
        public int? IsInternalMovement { get; set; }
    }
}
