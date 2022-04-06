using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PermissionAction
    {
        public int Id { get; set; }
        public int ActionId { get; set; }
        public int PermissionId { get; set; }

        public virtual UserAction Action { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
