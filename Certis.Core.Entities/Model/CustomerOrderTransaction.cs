using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerOrderTransaction
    {
        public int Id { get; set; }
        public int CustomerOrderSummaryId { get; set; }
        public int? PaymentGatewayId { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal TotalAmount { get; set; }
        public bool? IsSuccess { get; set; }
        public bool IsRefunded { get; set; }
        public string RefundRefNumber { get; set; }

        public virtual CustomerOrderSummary CustomerOrderSummary { get; set; }
        public virtual MasterReferenceDatum PaymentGateway { get; set; }
    }
}
