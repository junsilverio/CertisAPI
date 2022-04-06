using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SlotSchedule
    {
        public SlotSchedule()
        {
            SlotCustomers = new HashSet<SlotCustomer>();
            SlotScheduleDetails = new HashSet<SlotScheduleDetail>();
        }

        public int Id { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string SlotType { get; set; }
        public int ScheduleMasterId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? AllocatedStorage { get; set; }

        public virtual ScheduleMaster ScheduleMaster { get; set; }
        public virtual ICollection<SlotCustomer> SlotCustomers { get; set; }
        public virtual ICollection<SlotScheduleDetail> SlotScheduleDetails { get; set; }
    }
}
