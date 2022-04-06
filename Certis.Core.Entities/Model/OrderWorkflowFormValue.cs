using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderWorkflowFormValue
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? WorkFlowDetailId { get; set; }
        public int? WorkFlowActivityId { get; set; }
        public int? WorkFlowInput { get; set; }
        public string Value { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
