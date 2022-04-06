using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MastransportMaster
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int PickUpPoint { get; set; }
        public int DropOffPoint { get; set; }
        public DateTime? OrderDt { get; set; }
        public int? MasorderId { get; set; }
        public string Type { get; set; }
        public int? TeamId { get; set; }
        public string VersionNo { get; set; }
        public int? SequenceNo { get; set; }
        public int? JobGroupId { get; set; }
        public int? Status { get; set; }
        public DateTime? JobStartTime { get; set; }
        public DateTime? JobEndTime { get; set; }
        public byte[] CustomerSign { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? PerformedBy { get; set; }
        public string Instruction { get; set; }
        public string DeviceId { get; set; }
        public string CageNo { get; set; }

        public virtual Branch DropOffPointNavigation { get; set; }
        public virtual MasdepositOrderMaster Masorder { get; set; }
        public virtual MasterReferenceDatum StatusNavigation { get; set; }
    }
}
