using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BoxRequirement
    {
        public int Id { get; set; }
        public string OrderType { get; set; }
        public int OrderId { get; set; }
        public int Denom { get; set; }
        public int ActualQty { get; set; }
        public int AssignedQty { get; set; }
        public int? Series { get; set; }
        public decimal? ActualAmount { get; set; }
        public decimal? AssignedAmount { get; set; }
    }
}
