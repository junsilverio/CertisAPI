using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchConfigCollectionDetail
    {
        public int Id { get; set; }
        public int BranchConfigurationId { get; set; }
        public bool EnableAdhoc { get; set; }
        public bool EnableCancellation { get; set; }
        public bool EnableEdit { get; set; }
        public int? CreateOrderCutoffDays { get; set; }
        public int? CancellationCutoffDays { get; set; }
        public int? EditCutoffDays { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual BranchConfiguration BranchConfiguration { get; set; }
    }
}
