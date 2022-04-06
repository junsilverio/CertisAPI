using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwPackTrack
    {
        public long Id { get; set; }
        public int? PackId { get; set; }
        public int? CurrentOwner { get; set; }
        public string RoleName { get; set; }
        public string OrderNo { get; set; }
        public string Status { get; set; }
        public string CageNo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
