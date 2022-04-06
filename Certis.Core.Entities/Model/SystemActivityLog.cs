using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SystemActivityLog
    {
        public int Id { get; set; }
        public int? RefrenceId { get; set; }
        public string Entity { get; set; }
        public string Action { get; set; }
        public string Remarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? LastModifiedBy { get; set; }
    }
}
