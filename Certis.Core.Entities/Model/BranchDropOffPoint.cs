using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchDropOffPoint
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? DropOffId { get; set; }
        public string Instruction { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Branch DropOff { get; set; }
    }
}
