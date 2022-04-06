using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class WorkFlowStatusDetail
    {
        public int Id { get; set; }
        public int? WorkFlowMasterId { get; set; }
        public int? ApplicableStatus { get; set; }
        public bool? IsMandatory { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
