using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Customer
    {
        public Customer()
        {
            Branches = new HashSet<Branch>();
            CollectionPackTypeConfigs = new HashSet<CollectionPackTypeConfig>();
            Contracts = new HashSet<Contract>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerFeedbacks = new HashSet<CustomerFeedback>();
            CustomerOrderSummaries = new HashSet<CustomerOrderSummary>();
            CustomerProducts = new HashSet<CustomerProduct>();
            CustomerSettings = new HashSet<CustomerSetting>();
            CustomerUsers = new HashSet<CustomerUser>();
            MasdepositOrderMasters = new HashSet<MasdepositOrderMaster>();
            MasdepositOrders = new HashSet<MasdepositOrder>();
            OrderGroups = new HashSet<OrderGroup>();
            SecurityDeposits = new HashSet<SecurityDeposit>();
            SlotCustomers = new HashSet<SlotCustomer>();
        }

        public int Id { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int CustomerTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? RegistrationId { get; set; }
        public string ActiveStatus { get; set; }
        public bool IsDeleted { get; set; }
        public int? AccountManagerId { get; set; }
        public bool? ActionRequired { get; set; }
        public bool? PostPaidCustomer { get; set; }
        public bool? PostPaidStatus { get; set; }
        public int? MigratedId { get; set; }
        public string Currency { get; set; }

        public virtual User AccountManager { get; set; }
        public virtual MasterReferenceDatum CustomerType { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<CollectionPackTypeConfig> CollectionPackTypeConfigs { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }
        public virtual ICollection<CustomerOrderSummary> CustomerOrderSummaries { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<CustomerSetting> CustomerSettings { get; set; }
        public virtual ICollection<CustomerUser> CustomerUsers { get; set; }
        public virtual ICollection<MasdepositOrderMaster> MasdepositOrderMasters { get; set; }
        public virtual ICollection<MasdepositOrder> MasdepositOrders { get; set; }
        public virtual ICollection<OrderGroup> OrderGroups { get; set; }
        public virtual ICollection<SecurityDeposit> SecurityDeposits { get; set; }
        public virtual ICollection<SlotCustomer> SlotCustomers { get; set; }
    }
}
