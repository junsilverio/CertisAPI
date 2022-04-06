using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwOrderBagPackStatus
    {
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public bool? Confirmed { get; set; }
        public int? BagRequired { get; set; }
        public bool? BoxRequired { get; set; }
        public bool? IsPacked { get; set; }
        public bool? TeamAssigned { get; set; }
        public bool? ReadyToDeliver { get; set; }
        public bool? Delivered { get; set; }
        public int PendingToAssignBox { get; set; }
        public int? ApprovalPending { get; set; }
        public int? Cpcpending { get; set; }
        public int? Stupending { get; set; }
        public int? Cpcreject { get; set; }
        public int? Stureject { get; set; }
        public string OrderStatus { get; set; }
    }
}
