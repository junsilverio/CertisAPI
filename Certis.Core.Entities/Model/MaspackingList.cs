using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MaspackingList
    {
        public MaspackingList()
        {
            MasorderApprovalRequests = new HashSet<MasorderApprovalRequest>();
        }

        public int Id { get; set; }
        public int MasdetailsId { get; set; }
        public string BagNo { get; set; }
        public string CageNo { get; set; }
        public string SealType { get; set; }
        public int? Team { get; set; }
        public int? Status { get; set; }
        public bool? IsDelivered { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? CurrentOwner { get; set; }
        public int? DestinationOwner { get; set; }
        public int? DropOffPointId { get; set; }
        public int? IsSecurityApproved { get; set; }

        public virtual Role DestinationOwnerNavigation { get; set; }
        public virtual MasterReferenceDatum StatusNavigation { get; set; }
        public virtual MasterReferenceDatum TeamNavigation { get; set; }
        public virtual ICollection<MasorderApprovalRequest> MasorderApprovalRequests { get; set; }
    }
}
