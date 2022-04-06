using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EmailEvent
    {
        public int Id { get; set; }
        public string EventName { get; set; }
        public string Description { get; set; }
        public int? TemplateId { get; set; }
        public int? EmailGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
    }
}
