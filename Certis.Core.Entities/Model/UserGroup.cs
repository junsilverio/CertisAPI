using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            UserGroupUsers = new HashSet<UserGroupUser>();
        }

        public int Id { get; set; }
        public string UserGroup1 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserGroupUser> UserGroupUsers { get; set; }
    }
}
