using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderWorkflowHistory
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? WorkflowStatusId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual OrderMaster Order { get; set; }
    }
}
