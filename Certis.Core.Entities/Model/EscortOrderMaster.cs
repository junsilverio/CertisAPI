using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EscortOrderMaster
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int PickUpId { get; set; }
        public int? DropOffPoint { get; set; }
        public DateTime OrderDt { get; set; }
        public string OrderType { get; set; }
        public DateTime? StartWindow { get; set; }
        public DateTime? EndWindow { get; set; }
        public string ContactName { get; set; }
        public string ContactNo { get; set; }
        public int? TeamId { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Branch DropOffPointNavigation { get; set; }
        public virtual Branch PickUp { get; set; }
        public virtual MasterReferenceDatum Team { get; set; }
    }
}
