using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwTransportStatus
    {
        public int Id { get; set; }
        public string OrderType { get; set; }
        public string OrderStatus { get; set; }
    }
}
