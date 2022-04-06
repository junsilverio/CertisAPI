using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ContractAttributeValue
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public int? AttributeId { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual ContractAttribute Attribute { get; set; }
        public virtual Contract Contract { get; set; }
    }
}
