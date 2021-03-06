using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EntityActivityLog
    {
        public int Id { get; set; }
        public int? PrimaryKey { get; set; }
        public string Data { get; set; }
        public string LookUp { get; set; }
        public string Action { get; set; }
        public string Type { get; set; }
        public int? UserGroupId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
    }
}
