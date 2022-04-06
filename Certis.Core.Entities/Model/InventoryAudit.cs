using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class InventoryAudit
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public string Action { get; set; }
        public int? OriginalAccount { get; set; }
        public string OriginalItemType { get; set; }
        public string OriginalCurrency { get; set; }
        public int? OriginalDenomination { get; set; }
        public decimal? OriginalAmount { get; set; }
        public int? OriginalQuantity { get; set; }
        public int? OriginalSeries { get; set; }
        public int? OriginalLocation { get; set; }
        public int? NewAccount { get; set; }
        public string NewItemType { get; set; }
        public string NewCurrency { get; set; }
        public int? NewDenomination { get; set; }
        public decimal? NewAmount { get; set; }
        public int? NewQuantity { get; set; }
        public int? NewSeries { get; set; }
        public int? NewLocation { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreatedDt { get; set; }
        public string Purpose { get; set; }
    }
}
