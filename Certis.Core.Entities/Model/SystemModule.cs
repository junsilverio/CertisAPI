using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SystemModule
    {
        public SystemModule()
        {
            Permissions = new HashSet<Permission>();
        }

        public int Id { get; set; }
        public string ModuleName { get; set; }
        public int? DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public string ApplicationType { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
