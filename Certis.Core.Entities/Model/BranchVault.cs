using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchVault
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? VaultId { get; set; }
    }
}
