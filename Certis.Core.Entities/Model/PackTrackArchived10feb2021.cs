using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PackTrackArchived10feb2021
    {
        public long Id { get; set; }
        public int? PackId { get; set; }
        public int? CollectionPackId { get; set; }
        public int? CurrentOwner { get; set; }
        public int? DestinationOwner { get; set; }
        public string GroupNo { get; set; }
        public string CageNo { get; set; }
        public string CageId { get; set; }
        public int? Step { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int? TargetTeam { get; set; }
        public int? CashierId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? OriginDropOffPoint { get; set; }
    }
}
