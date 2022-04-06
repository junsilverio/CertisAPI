using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VaultDeliveryTransportDetail
    {
        public int Id { get; set; }
        public int? CollectionOrderId { get; set; }
        public int? TransportDetailsId { get; set; }
    }
}
