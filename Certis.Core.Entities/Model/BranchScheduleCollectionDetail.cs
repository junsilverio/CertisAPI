using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchScheduleCollectionDetail
    {
        public int Id { get; set; }
        public int? BranchScheduleId { get; set; }
        public int? DropOffPoint { get; set; }
        public int? DropAfterDays { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? VaultId { get; set; }
        public DateTime? DeliveryFromTime { get; set; }
        public DateTime? DeliveryToTime { get; set; }
        public int? SequenceNo { get; set; }
        public int? BranchId { get; set; }
        public bool? Wknd { get; set; }
        public bool? Ph { get; set; }
        public string Remarks { get; set; }
        public int? OrderSequnceNo { get; set; }
        public string BillingNo { get; set; }
        public DateTime? FromTime { get; set; }
        public DateTime? ToTime { get; set; }
        public int? OrderCustomerId { get; set; }
        public string ClientInstruction { get; set; }

        public virtual BranchSchedule BranchSchedule { get; set; }
        public virtual Branch DropOffPointNavigation { get; set; }
    }
}
