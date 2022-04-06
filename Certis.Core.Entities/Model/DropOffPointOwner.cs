using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DropOffPointOwner
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? RoleId { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Role Role { get; set; }
    }
}
