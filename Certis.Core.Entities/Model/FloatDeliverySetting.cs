using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class FloatDeliverySetting
    {
        public int Id { get; set; }
        public int? BranchConfigurationId { get; set; }
        public int? DefaultTemplateId { get; set; }
        public int? FloatSourceId { get; set; }
        public bool EnableAdhoc { get; set; }
        public bool FixedSchedule { get; set; }
        public bool FixedAmount { get; set; }
        public bool IsStandardOrder { get; set; }
        public bool CanSubmit { get; set; }
        public bool CiscoCpcinvolved { get; set; }
        public bool CiscoVaultInvolved { get; set; }
        public bool ApprovalRequired { get; set; }
        public int? PreOrPostponeDeliveryDayBy { get; set; }
        public bool CanEditOrder { get; set; }
        public int? MaxAdvanceOrderDays { get; set; }
        public int CanEditOrderBefore { get; set; }
        public bool IsStandardPack { get; set; }
        public bool IsCashCollectionInvolved { get; set; }
        public bool ScheduledCollection { get; set; }
        public int? StandardPackAmount { get; set; }
        public int? DefaultWorkflow { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual BranchConfiguration BranchConfiguration { get; set; }
        public virtual Template DefaultTemplate { get; set; }
        public virtual MasterReferenceDatum FloatSource { get; set; }
    }
}
