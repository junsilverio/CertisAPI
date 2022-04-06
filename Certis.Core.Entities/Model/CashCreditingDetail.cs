using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CashCreditingDetail
    {
        public int Id { get; set; }
        public int? CollectionRefId { get; set; }
        public decimal? CollectedAmount { get; set; }
        public decimal? CreditedAmount { get; set; }
        public string AccountNo { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
    }
}
