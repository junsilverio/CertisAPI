using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerUserBranch
    {
        public int Id { get; set; }
        public int CustomerUserId { get; set; }
        public int BranchId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual CustomerUser CustomerUser { get; set; }
    }
}
