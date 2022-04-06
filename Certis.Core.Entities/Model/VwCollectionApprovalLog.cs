using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwCollectionApprovalLog
    {
        public int CollectionId { get; set; }
        public int? TotalCount { get; set; }
        public int? ApprovedCount { get; set; }
        public int? RejectedCount { get; set; }
    }
}
