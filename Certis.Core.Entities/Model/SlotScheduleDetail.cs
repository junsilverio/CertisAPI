using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SlotScheduleDetail
    {
        public SlotScheduleDetail()
        {
            Slots = new HashSet<Slot>();
        }

        public int Id { get; set; }
        public int SlotScheduleId { get; set; }
        public DateTime ScheduledDate { get; set; }
        public TimeSpan? StartWindow { get; set; }
        public TimeSpan? EndWindow { get; set; }
        public decimal? AllocatedStorage { get; set; }
        public int? SlotCutoffHours { get; set; }
        public int? SlotPriceId { get; set; }
        public decimal? Price { get; set; }
        public bool? IsDynamic { get; set; }
        public int? NumberOfJobs { get; set; }
        public int? Cittypeid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public decimal? DynamicIncrement { get; set; }

        public virtual MasterReferenceDatum Cittype { get; set; }
        public virtual SlotPricing SlotPrice { get; set; }
        public virtual SlotSchedule SlotSchedule { get; set; }
        public virtual ICollection<Slot> Slots { get; set; }
    }
}
