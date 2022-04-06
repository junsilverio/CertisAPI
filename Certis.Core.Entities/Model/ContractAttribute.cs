using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ContractAttribute
    {
        public ContractAttribute()
        {
            ContractAttributeValues = new HashSet<ContractAttributeValue>();
        }

        public int Id { get; set; }
        public string ContractAttribute1 { get; set; }
        public string ContractAttributeCode { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual ICollection<ContractAttributeValue> ContractAttributeValues { get; set; }
    }
}
