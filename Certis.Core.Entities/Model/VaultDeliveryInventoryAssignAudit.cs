using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VaultDeliveryInventoryAssignAudit
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int? AccountId { get; set; }
        public int? LocationId { get; set; }
        public string Remarks { get; set; }
        public string ItemType { get; set; }
        public string Currency { get; set; }
        public int? DenominationId { get; set; }
        public int? Series { get; set; }
        public int? Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
    }
}
