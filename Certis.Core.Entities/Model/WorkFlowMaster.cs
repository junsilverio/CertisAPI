using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class WorkFlowMaster
    {
        public int Id { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowCode { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
