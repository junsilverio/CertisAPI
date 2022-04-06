using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwVaultDeliveryOrder
    {
        public int? CollectionRefId { get; set; }
        public int TransportId { get; set; }
    }
}
