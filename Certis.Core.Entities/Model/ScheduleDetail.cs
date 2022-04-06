using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ScheduleDetail
    {
        public int Id { get; set; }
        public int ScheduleMasterId { get; set; }
        public int? Occurence { get; set; }
        public string Rule { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ScheduleMaster ScheduleMaster { get; set; }
    }
}
