using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SlotCustomer
    {
        public int Id { get; set; }
        public int SlotScheduleId { get; set; }
        public int CustomerId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual SlotSchedule SlotSchedule { get; set; }
    }
}
