using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DevicePermissionRequest
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string Module { get; set; }
        public string RequestType { get; set; }
        public int? RequestedBy { get; set; }
        public DateTime? RequestedOn { get; set; }
        public string Status { get; set; }
        public int? RespondedBy { get; set; }
        public string Remarks { get; set; }
        public string FunLoc { get; set; }
        public string Location { get; set; }
        public string Customer { get; set; }
        public string DeviceId { get; set; }
    }
}
