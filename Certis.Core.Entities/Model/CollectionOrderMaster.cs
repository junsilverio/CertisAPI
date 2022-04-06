using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CollectionOrderMaster
    {
        public CollectionOrderMaster()
        {
            CollectionOrderApprovals = new HashSet<CollectionOrderApproval>();
            CollectionOrderDetails = new HashSet<CollectionOrderDetail>();
            OrderMasters = new HashSet<OrderMaster>();
            TransportMasters = new HashSet<TransportMaster>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int BranchId { get; set; }
        public int? DropOffPoint { get; set; }
        public DateTime OrderDt { get; set; }
        public string OrderType { get; set; }
        public DateTime? CollectionFromTime { get; set; }
        public DateTime? CollectionToTime { get; set; }
        public bool IncludeDelivery { get; set; }
        public DateTime? DropoffDt { get; set; }
        public DateTime? DeliveryFromTime { get; set; }
        public DateTime? DeliveryToTime { get; set; }
        public string ContactName { get; set; }
        public string ContactNo { get; set; }
        public decimal? Amount { get; set; }
        public int? TeamId { get; set; }
        public bool? IsActive { get; set; }
        public string Remarks { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedRemarks { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public string Consumables { get; set; }
        public string GroupNo { get; set; }
        public int? NonCertisServiceTypeId { get; set; }
        public string OrderAction { get; set; }
        public int? VaultId { get; set; }
        public int? ScheduleId { get; set; }
        public string BillingNo { get; set; }
        public int? OrderCustomerId { get; set; }
        public int? FunLocId { get; set; }
        public int? IncludeInBank { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Branch DropOffPointNavigation { get; set; }
        public virtual MasterReferenceDatum Team { get; set; }
        public virtual ICollection<CollectionOrderApproval> CollectionOrderApprovals { get; set; }
        public virtual ICollection<CollectionOrderDetail> CollectionOrderDetails { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
        public virtual ICollection<TransportMaster> TransportMasters { get; set; }
    }
}
