using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BoxAssignLog
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public string Action { get; set; }
        public int? CustomerAccount { get; set; }
        public string ItemType { get; set; }
        public int? CurrencyId { get; set; }
        public int? DenominationId { get; set; }
        public int? SeriesId { get; set; }
        public int? Qty { get; set; }
        public string Site { get; set; }
        public int? LocationId { get; set; }
        public string ToSite { get; set; }
        public int? ToLocationId { get; set; }
        public string Seal { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserId { get; set; }
    }
}
