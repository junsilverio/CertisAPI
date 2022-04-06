using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderStorage
    {
        public int Id { get; set; }
        public int CustomerOrderSummaryId { get; set; }
        public int? SlotId { get; set; }
        public DateTime StorageDate { get; set; }
        public decimal ConsumedSpace { get; set; }
        public decimal Price { get; set; }

        public virtual CustomerOrderSummary CustomerOrderSummary { get; set; }
        public virtual Slot Slot { get; set; }
    }
}
