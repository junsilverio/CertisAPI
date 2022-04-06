using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VaultDeliveryItemDetail
    {
        public int Id { get; set; }
        public int? CollectionOrderId { get; set; }
        public string Deliverables { get; set; }
        public string DeliverablesWithSeries { get; set; }
    }
}
