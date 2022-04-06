using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwApprovalLog
    {
        public int OrderId { get; set; }
        public int? TotalCount { get; set; }
        public int? ApprovedCount { get; set; }
        public int? RejectCount { get; set; }
    }
}
