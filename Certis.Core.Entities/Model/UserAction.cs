using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class UserAction
    {
        public UserAction()
        {
            PermissionActions = new HashSet<PermissionAction>();
            PermissionRoles = new HashSet<PermissionRole>();
        }

        public int Id { get; set; }
        public string Action { get; set; }
        public string ActionCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<PermissionAction> PermissionActions { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
    }
}
