using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ScheduleMaster
    {
        public ScheduleMaster()
        {
            BranchSchedules = new HashSet<BranchSchedule>();
            SlotSchedules = new HashSet<SlotSchedule>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public string IntervalType { get; set; }

        public virtual ICollection<BranchSchedule> BranchSchedules { get; set; }
        public virtual ICollection<SlotSchedule> SlotSchedules { get; set; }
    }
}
