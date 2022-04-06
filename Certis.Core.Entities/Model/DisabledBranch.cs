using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DisabledBranch
    {
        public int Id { get; set; }
        public int BranchId { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsPermanentDelete { get; set; }

        public virtual Branch Branch { get; set; }
    }
}
