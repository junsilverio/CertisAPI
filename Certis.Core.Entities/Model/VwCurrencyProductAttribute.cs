using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwCurrencyProductAttribute
    {
        public int? ProductId { get; set; }
        public decimal? ProductValue { get; set; }
        public string IsCoin { get; set; }
        public string CurrencyType { get; set; }
        public string RollStackCount { get; set; }
        public string RollStackAmount { get; set; }
        public string RollStackInBox { get; set; }
        public string BoxAmount { get; set; }
        public string BundleCount { get; set; }
        public string BundleAmount { get; set; }
        public string Currency { get; set; }
    }
}
