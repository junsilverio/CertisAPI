using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class FloatDeliveryReScheduleRequest
    {
        public int Id { get; set; }
        public int? OrderMasterId { get; set; }
        public int? RequestedBy { get; set; }
        public DateTime? ReScheduleDt { get; set; }
        public DateTime? RequestedOn { get; set; }
        public string Remark { get; set; }
        public byte[] CustomerSign { get; set; }
        public bool? IsDeleted { get; set; }
        public string Status { get; set; }
    }
}
