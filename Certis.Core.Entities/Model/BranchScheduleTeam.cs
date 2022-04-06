using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchScheduleTeam
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int? MondayTeam { get; set; }
        public int? TuesdayTeam { get; set; }
        public int? WednesdayTeam { get; set; }
        public int? ThursdayTeam { get; set; }
        public int? FridayTeam { get; set; }
        public int? SaturdayTeam { get; set; }
        public int? SundayTeam { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual BranchSchedule Schedule { get; set; }
    }
}
