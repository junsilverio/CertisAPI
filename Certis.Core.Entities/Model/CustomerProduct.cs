using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerProduct
    {
        public CustomerProduct()
        {
            TemplateDetails = new HashSet<TemplateDetail>();
        }

        public int Id { get; set; }
        public int ProductId { get; set; }
        public double MaxLimit { get; set; }
        public int CustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<TemplateDetail> TemplateDetails { get; set; }
    }
}
