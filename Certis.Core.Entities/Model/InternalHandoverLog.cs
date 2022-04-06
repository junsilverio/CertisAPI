using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class InternalHandoverLog
    {
        public int Id { get; set; }
        public string Action { get; set; }
        public string ItemType { get; set; }
        public int? Account { get; set; }
        public int? ProductId { get; set; }
        public int? CoinSeriesId { get; set; }
        public int? Quantity { get; set; }
        public string CageNo { get; set; }
        public string CageId { get; set; }
        public int? SourceLocationId { get; set; }
        public int? DestinationLocationId { get; set; }
        public DateTime? ActionDateTime { get; set; }
        public int? ActionBy { get; set; }
    }
}
