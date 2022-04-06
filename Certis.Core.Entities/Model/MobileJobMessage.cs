using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MobileJobMessage
    {
        public int Id { get; set; }
        public string TeamId { get; set; }
        public string TextMessage { get; set; }
        public string MessagePriority { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public bool ReadStatus { get; set; }
        public DateTime? ReadTime { get; set; }
        public int? ParentId { get; set; }
        public bool? IsFromDevice { get; set; }
    }
}
