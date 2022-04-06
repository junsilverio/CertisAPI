using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwOrderWorkFlowStatus
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public int? Delivered { get; set; }
        public int? OrderApproved { get; set; }
        public int? Packed { get; set; }
        public int? TeamAssigned { get; set; }
    }
}
