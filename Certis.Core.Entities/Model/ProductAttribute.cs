using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            ProductAttributeValues = new HashSet<ProductAttributeValue>();
        }

        public int Id { get; set; }
        public string AttributeName { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ProductAttributeValue> ProductAttributeValues { get; set; }
    }
}
