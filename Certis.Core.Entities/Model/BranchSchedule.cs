using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchSchedule
    {
        public BranchSchedule()
        {
            BranchScheduleCollectionDetails = new HashSet<BranchScheduleCollectionDetail>();
            BranchScheduleTeams = new HashSet<BranchScheduleTeam>();
            ScheduledDates = new HashSet<ScheduledDate>();
        }

        public int Id { get; set; }
        public int BranchId { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? ScheduleMasterId { get; set; }
        public int? TemplateId { get; set; }
        public int? TeamId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int ContractId { get; set; }
        public int ServiceTypeId { get; set; }
        public int? RefId { get; set; }
        public string BillingNo { get; set; }
        public int? JobSequenceNo { get; set; }
        public int? DropOffPoint { get; set; }
        public bool? Wknd { get; set; }
        public bool? Ph { get; set; }
        public string Remarks { get; set; }
        public int? OrderCustomerId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ScheduleMaster ScheduleMaster { get; set; }
        public virtual MasterReferenceDatum ServiceType { get; set; }
        public virtual Template Template { get; set; }
        public virtual ICollection<BranchScheduleCollectionDetail> BranchScheduleCollectionDetails { get; set; }
        public virtual ICollection<BranchScheduleTeam> BranchScheduleTeams { get; set; }
        public virtual ICollection<ScheduledDate> ScheduledDates { get; set; }
    }
}
