using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class TransportDetail
    {
        public TransportDetail()
        {
            PackTracks = new HashSet<PackTrack>();
            TransportEnvelops = new HashSet<TransportEnvelop>();
        }

        public int Id { get; set; }
        public int? TransportId { get; set; }
        public string ItemType { get; set; }
        public string SealNo { get; set; }
        public string SealNo2 { get; set; }
        public int? Denomination { get; set; }
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public string Remarks { get; set; }
        public bool? ReadyToDeliver { get; set; }
        public DateTime? ScannedTimeStamp { get; set; }
        public int? ScannedBy { get; set; }
        public bool? AssignedToTeam { get; set; }
        public string ComputedColumn { get; set; }
        public bool IsPrePacked { get; set; }
        public int? CoinSeries { get; set; }
        public int? InventoryAccountId { get; set; }
        public bool? IsSafeKeepItem { get; set; }
        public DateTime? VcsscannedTimeStamp { get; set; }
        public int? VcsscannedBy { get; set; }
        public int? IsInternalTransfer { get; set; }
        public string Purpose { get; set; }

        public virtual TransportMaster Transport { get; set; }
        public virtual ICollection<PackTrack> PackTracks { get; set; }
        public virtual ICollection<TransportEnvelop> TransportEnvelops { get; set; }
    }
}
