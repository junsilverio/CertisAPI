using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasterReferenceDatum
    {
        public MasterReferenceDatum()
        {
            BranchConfigurations = new HashSet<BranchConfiguration>();
            BranchSchedules = new HashSet<BranchSchedule>();
            CollectionOrderMasters = new HashSet<CollectionOrderMaster>();
            ContractFloatSources = new HashSet<ContractFloatSource>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerOrderSummaries = new HashSet<CustomerOrderSummary>();
            CustomerOrderTransactions = new HashSet<CustomerOrderTransaction>();
            CustomerRegistrations = new HashSet<CustomerRegistration>();
            Customers = new HashSet<Customer>();
            EscortOrderMasters = new HashSet<EscortOrderMaster>();
            FloatDeliverySettings = new HashSet<FloatDeliverySetting>();
            MasdepositOrderCategories = new HashSet<MasdepositOrder>();
            MasdepositOrderCurrencyTypes = new HashSet<MasdepositOrder>();
            MasdepositOrderDetailCategories = new HashSet<MasdepositOrderDetail>();
            MasdepositOrderDetailCurrencyTypes = new HashSet<MasdepositOrderDetail>();
            MasdepositOrderDetailForms = new HashSet<MasdepositOrderDetail>();
            MasdepositOrderDetailParentCategories = new HashSet<MasdepositOrderDetail>();
            MasdepositOrderDetailSeries = new HashSet<MasdepositOrderDetail>();
            MasdepositOrderSeries = new HashSet<MasdepositOrder>();
            MasformsSettingCategories = new HashSet<MasformsSetting>();
            MasformsSettingCurrencyTypes = new HashSet<MasformsSetting>();
            MasformsSettingForms = new HashSet<MasformsSetting>();
            MasformsSettingSeries = new HashSet<MasformsSetting>();
            MasorderHistories = new HashSet<MasorderHistory>();
            MaspackingListStatusNavigations = new HashSet<MaspackingList>();
            MaspackingListTeamNavigations = new HashSet<MaspackingList>();
            MastransportMasters = new HashSet<MastransportMaster>();
            OrderTeamAllocations = new HashSet<OrderTeamAllocation>();
            RegistrationHistoryApprovedSubscriptionTypes = new HashSet<RegistrationHistory>();
            RegistrationHistoryReqSubscriptionTypes = new HashSet<RegistrationHistory>();
            Registrations = new HashSet<Registration>();
            SlotPricings = new HashSet<SlotPricing>();
            SlotScheduleDetails = new HashSet<SlotScheduleDetail>();
            SlotTypes = new HashSet<SlotType>();
            Stuteams = new HashSet<Stuteam>();
            SubscriptionServiceConfigServiceTypes = new HashSet<SubscriptionServiceConfig>();
            SubscriptionServiceConfigSubscriptionTypes = new HashSet<SubscriptionServiceConfig>();
            TransportMasterStatusNavigations = new HashSet<TransportMaster>();
            TransportMasterTeams = new HashSet<TransportMaster>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string DataAbbr { get; set; }
        public string DataDesc { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ReferenceDataCategory Category { get; set; }
        public virtual ICollection<BranchConfiguration> BranchConfigurations { get; set; }
        public virtual ICollection<BranchSchedule> BranchSchedules { get; set; }
        public virtual ICollection<CollectionOrderMaster> CollectionOrderMasters { get; set; }
        public virtual ICollection<ContractFloatSource> ContractFloatSources { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerOrderSummary> CustomerOrderSummaries { get; set; }
        public virtual ICollection<CustomerOrderTransaction> CustomerOrderTransactions { get; set; }
        public virtual ICollection<CustomerRegistration> CustomerRegistrations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<EscortOrderMaster> EscortOrderMasters { get; set; }
        public virtual ICollection<FloatDeliverySetting> FloatDeliverySettings { get; set; }
        public virtual ICollection<MasdepositOrder> MasdepositOrderCategories { get; set; }
        public virtual ICollection<MasdepositOrder> MasdepositOrderCurrencyTypes { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetailCategories { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetailCurrencyTypes { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetailForms { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetailParentCategories { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetailSeries { get; set; }
        public virtual ICollection<MasdepositOrder> MasdepositOrderSeries { get; set; }
        public virtual ICollection<MasformsSetting> MasformsSettingCategories { get; set; }
        public virtual ICollection<MasformsSetting> MasformsSettingCurrencyTypes { get; set; }
        public virtual ICollection<MasformsSetting> MasformsSettingForms { get; set; }
        public virtual ICollection<MasformsSetting> MasformsSettingSeries { get; set; }
        public virtual ICollection<MasorderHistory> MasorderHistories { get; set; }
        public virtual ICollection<MaspackingList> MaspackingListStatusNavigations { get; set; }
        public virtual ICollection<MaspackingList> MaspackingListTeamNavigations { get; set; }
        public virtual ICollection<MastransportMaster> MastransportMasters { get; set; }
        public virtual ICollection<OrderTeamAllocation> OrderTeamAllocations { get; set; }
        public virtual ICollection<RegistrationHistory> RegistrationHistoryApprovedSubscriptionTypes { get; set; }
        public virtual ICollection<RegistrationHistory> RegistrationHistoryReqSubscriptionTypes { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<SlotPricing> SlotPricings { get; set; }
        public virtual ICollection<SlotScheduleDetail> SlotScheduleDetails { get; set; }
        public virtual ICollection<SlotType> SlotTypes { get; set; }
        public virtual ICollection<Stuteam> Stuteams { get; set; }
        public virtual ICollection<SubscriptionServiceConfig> SubscriptionServiceConfigServiceTypes { get; set; }
        public virtual ICollection<SubscriptionServiceConfig> SubscriptionServiceConfigSubscriptionTypes { get; set; }
        public virtual ICollection<TransportMaster> TransportMasterStatusNavigations { get; set; }
        public virtual ICollection<TransportMaster> TransportMasterTeams { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
