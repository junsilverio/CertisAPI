using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Slot
    {
        public Slot()
        {
            CustomerOrderSummaryDeliverySlots = new HashSet<CustomerOrderSummary>();
            CustomerOrderSummaryPickupSlots = new HashSet<CustomerOrderSummary>();
            OrderStorages = new HashSet<OrderStorage>();
        }

        public int Id { get; set; }
        public int SlotScheduleDetailId { get; set; }
        public DateTime? BlockedDate { get; set; }
        public DateTime? BlockReleaseDate { get; set; }
        public bool IsBooked { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? BlockedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public decimal? StorageSize { get; set; }
        public decimal Price { get; set; }
        public decimal? DynamicCharge { get; set; }

        public virtual SlotScheduleDetail SlotScheduleDetail { get; set; }
        public virtual ICollection<CustomerOrderSummary> CustomerOrderSummaryDeliverySlots { get; set; }
        public virtual ICollection<CustomerOrderSummary> CustomerOrderSummaryPickupSlots { get; set; }
        public virtual ICollection<OrderStorage> OrderStorages { get; set; }
    }
}
