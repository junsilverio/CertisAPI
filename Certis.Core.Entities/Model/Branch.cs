using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Branch
    {
        public Branch()
        {
            BankOrders = new HashSet<BankOrder>();
            BranchConfigDropOffPoints = new HashSet<BranchConfigDropOffPoint>();
            BranchConfigurations = new HashSet<BranchConfiguration>();
            BranchDropOffPointBranches = new HashSet<BranchDropOffPoint>();
            BranchDropOffPointDropOffs = new HashSet<BranchDropOffPoint>();
            BranchScheduleCollectionDetails = new HashSet<BranchScheduleCollectionDetail>();
            BranchSchedules = new HashSet<BranchSchedule>();
            BranchTransportSettings = new HashSet<BranchTransportSetting>();
            CollectionOrderMasterBranches = new HashSet<CollectionOrderMaster>();
            CollectionOrderMasterDropOffPointNavigations = new HashSet<CollectionOrderMaster>();
            ContractApprovalRules = new HashSet<ContractApprovalRule>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerUserBranches = new HashSet<CustomerUserBranch>();
            CustomerUsers = new HashSet<CustomerUser>();
            DayTemplates = new HashSet<DayTemplate>();
            DisabledBranches = new HashSet<DisabledBranch>();
            DropOffPointOwners = new HashSet<DropOffPointOwner>();
            EscortOrderMasterDropOffPointNavigations = new HashSet<EscortOrderMaster>();
            EscortOrderMasterPickUps = new HashSet<EscortOrderMaster>();
            MastransportMasters = new HashSet<MastransportMaster>();
            OrderMasters = new HashSet<OrderMaster>();
            ScheduledDates = new HashSet<ScheduledDate>();
            TemplateBranches = new HashSet<TemplateBranch>();
            TransportMasterDropOffPointNavigations = new HashSet<TransportMaster>();
            TransportMasterPickUpPointNavigations = new HashSet<TransportMaster>();
        }

        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string FunctionalCode { get; set; }
        public int CustomerId { get; set; }
        public int BranchAddressId { get; set; }
        public bool IsBranch { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHeadOffice { get; set; }
        public string BranchName { get; set; }
        public string Remarks { get; set; }
        public bool? IsPrimary { get; set; }
        public int? MigratedId { get; set; }
        public bool? IsTemporaryDeleted { get; set; }
        public int? IsInventory { get; set; }
        public int? IsSafekeep { get; set; }
        public string BranchNumber { get; set; }

        public virtual Address BranchAddress { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<BankOrder> BankOrders { get; set; }
        public virtual ICollection<BranchConfigDropOffPoint> BranchConfigDropOffPoints { get; set; }
        public virtual ICollection<BranchConfiguration> BranchConfigurations { get; set; }
        public virtual ICollection<BranchDropOffPoint> BranchDropOffPointBranches { get; set; }
        public virtual ICollection<BranchDropOffPoint> BranchDropOffPointDropOffs { get; set; }
        public virtual ICollection<BranchScheduleCollectionDetail> BranchScheduleCollectionDetails { get; set; }
        public virtual ICollection<BranchSchedule> BranchSchedules { get; set; }
        public virtual ICollection<BranchTransportSetting> BranchTransportSettings { get; set; }
        public virtual ICollection<CollectionOrderMaster> CollectionOrderMasterBranches { get; set; }
        public virtual ICollection<CollectionOrderMaster> CollectionOrderMasterDropOffPointNavigations { get; set; }
        public virtual ICollection<ContractApprovalRule> ContractApprovalRules { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerUserBranch> CustomerUserBranches { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<DayTemplate> DayTemplates { get; set; }
        public virtual ICollection<DisabledBranch> DisabledBranches { get; set; }
        public virtual ICollection<DropOffPointOwner> DropOffPointOwners { get; set; }
        public virtual ICollection<EscortOrderMaster> EscortOrderMasterDropOffPointNavigations { get; set; }
        public virtual ICollection<EscortOrderMaster> EscortOrderMasterPickUps { get; set; }
        public virtual ICollection<MastransportMaster> MastransportMasters { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
        public virtual ICollection<ScheduledDate> ScheduledDates { get; set; }
        public virtual ICollection<TemplateBranch> TemplateBranches { get; set; }
        public virtual ICollection<TransportMaster> TransportMasterDropOffPointNavigations { get; set; }
        public virtual ICollection<TransportMaster> TransportMasterPickUpPointNavigations { get; set; }
    }
}
