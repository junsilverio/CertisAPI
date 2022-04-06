using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchConfigDropOffPoint
    {
        public int Id { get; set; }
        public int? BranchConfigId { get; set; }
        public int? DropOffPointId { get; set; }

        public virtual BranchConfiguration BranchConfig { get; set; }
        public virtual Branch DropOffPoint { get; set; }
    }
}
