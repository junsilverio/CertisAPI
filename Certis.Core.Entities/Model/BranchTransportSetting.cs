using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchTransportSetting
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public DateTime? BlockStartTime { get; set; }
        public DateTime? BlockEndTime { get; set; }
        public int? TransactionTime { get; set; }
        public string EstimatedCash { get; set; }
        public string Remarks { get; set; }
        public string ContactNo { get; set; }
        public string Cittype { get; set; }
        public string Citdetails { get; set; }
        public string JobTag { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
