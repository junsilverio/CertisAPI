using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ProductAttributeValue
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? AttributeId { get; set; }
        public string Value { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ProductAttribute Attribute { get; set; }
        public virtual Product Product { get; set; }
    }
}
