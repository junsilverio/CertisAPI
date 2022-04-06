using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Ncctemplate
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? LastModifiedby { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
