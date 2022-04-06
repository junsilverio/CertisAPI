using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ContractApprovalRule
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int? BranchId { get; set; }
        public int OrderApprovalRuleId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual OrderApprovalRule OrderApprovalRule { get; set; }
    }
}
