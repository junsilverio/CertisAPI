using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderGroup
    {
        public OrderGroup()
        {
            OrderMasters = new HashSet<OrderMaster>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDt { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalAmount { get; set; }
        public string OrderType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
    }
}
