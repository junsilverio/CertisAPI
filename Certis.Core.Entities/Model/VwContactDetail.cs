using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwContactDetail
    {
        public string ContactDetail { get; set; }
        public string ContactType { get; set; }
        public int? BranchId { get; set; }
    }
}
