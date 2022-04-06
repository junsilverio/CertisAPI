using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerFeedback
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int? CustomerOrderSummaryId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerOrderSummary CustomerOrderSummary { get; set; }
    }
}
