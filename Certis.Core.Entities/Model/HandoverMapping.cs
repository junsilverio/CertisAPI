using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class HandoverMapping
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SourceRole { get; set; }
        public int DestinationRole { get; set; }
        public string PackSource { get; set; }
        public int? ApprovalOwnerRoleId { get; set; }

        public virtual Role ApprovalOwnerRole { get; set; }
        public virtual Role DestinationRoleNavigation { get; set; }
        public virtual Role SourceRoleNavigation { get; set; }
    }
}
