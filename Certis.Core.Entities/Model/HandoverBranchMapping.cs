using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class HandoverBranchMapping
    {
        public int Id { get; set; }
        public int Source { get; set; }
        public int Destination { get; set; }
        public string ApprovalOwnerRoleId { get; set; }
        public string TransportOwnerRoleId { get; set; }
    }
}
