using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderApprovalRule
    {
        public OrderApprovalRule()
        {
            ContractApprovalRules = new HashSet<ContractApprovalRule>();
        }

        public int Id { get; set; }
        public string RuleName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ContractApprovalRule> ContractApprovalRules { get; set; }
    }
}
