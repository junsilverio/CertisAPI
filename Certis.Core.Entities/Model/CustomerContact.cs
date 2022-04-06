using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerContact
    {
        public int Id { get; set; }
        public string ContactDetail { get; set; }
        public int ContactTypeId { get; set; }
        public bool IsDefault { get; set; }
        public int? BranchId { get; set; }
        public int? CustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual MasterReferenceDatum ContactType { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
