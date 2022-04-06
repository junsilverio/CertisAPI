using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwRoleHeirarchy
    {
        public int? Id { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public int? ParentId { get; set; }
        public string Parents { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
