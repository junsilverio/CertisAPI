using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class TeamBreakLog
    {
        public int Id { get; set; }
        public int? TeamId { get; set; }
        public DateTime? BreakDt { get; set; }
        public DateTime? RequestedOn { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public int? Duration { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public bool? Consumed { get; set; }
        public bool? IsDeleted { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CancelledOn { get; set; }
        public int? CancelledBy { get; set; }
        public string CancelledRemarks { get; set; }
    }
}
