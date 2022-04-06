using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Contract
    {
        public Contract()
        {
            BankOrders = new HashSet<BankOrder>();
            BranchConfigurations = new HashSet<BranchConfiguration>();
            BranchSchedules = new HashSet<BranchSchedule>();
            ContractApprovalRules = new HashSet<ContractApprovalRule>();
            ContractAttributeValues = new HashSet<ContractAttributeValue>();
            ContractFloatSources = new HashSet<ContractFloatSource>();
            ContractServiceTypes = new HashSet<ContractServiceType>();
            OrderMasters = new HashSet<OrderMaster>();
        }

        public int Id { get; set; }
        public string ContractCode { get; set; }
        public string SapidentificationCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ParentId { get; set; }
        public int? OrderPlaceBeforeOrAfter { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<BankOrder> BankOrders { get; set; }
        public virtual ICollection<BranchConfiguration> BranchConfigurations { get; set; }
        public virtual ICollection<BranchSchedule> BranchSchedules { get; set; }
        public virtual ICollection<ContractApprovalRule> ContractApprovalRules { get; set; }
        public virtual ICollection<ContractAttributeValue> ContractAttributeValues { get; set; }
        public virtual ICollection<ContractFloatSource> ContractFloatSources { get; set; }
        public virtual ICollection<ContractServiceType> ContractServiceTypes { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
    }
}
