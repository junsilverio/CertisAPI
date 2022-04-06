using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Permission
    {
        public Permission()
        {
            PermissionActions = new HashSet<PermissionAction>();
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }
        public string PermissionName { get; set; }
        public string PermissionCode { get; set; }
        public string AccessCode { get; set; }
        public int? ModuleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual SystemModule Module { get; set; }
        public virtual ICollection<PermissionAction> PermissionActions { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
