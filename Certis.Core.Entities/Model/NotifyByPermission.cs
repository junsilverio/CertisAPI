using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class NotifyByPermission
    {
        public int Id { get; set; }
        public int? PermissionId { get; set; }
        public string Type { get; set; }
        public string MessageTemplate { get; set; }
        public string ReDirectTo { get; set; }
        public string EventType { get; set; }
        public string RoleId { get; set; }
    }
}
