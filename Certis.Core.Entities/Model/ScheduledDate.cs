using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ScheduledDate
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public int BranchScheduleId { get; set; }
        public DateTime ScheduleDt { get; set; }
        public int Day { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsActive { get; set; }
        public string BillingNo { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual BranchSchedule BranchSchedule { get; set; }
    }
}
