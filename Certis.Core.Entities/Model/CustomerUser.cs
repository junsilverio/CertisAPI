using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerUser
    {
        public CustomerUser()
        {
            CustomerOrderSummaries = new HashSet<CustomerOrderSummary>();
            CustomerUserBranches = new HashSet<CustomerUserBranch>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public int? BranchId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsAdmin { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual ICollection<CustomerOrderSummary> CustomerOrderSummaries { get; set; }
        public virtual ICollection<CustomerUserBranch> CustomerUserBranches { get; set; }
    }
}
