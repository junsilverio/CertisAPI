using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwCustomerUserMapping
    {
        public int UserId { get; set; }
        public int BranchId { get; set; }
        public string FullName { get; set; }
    }
}
