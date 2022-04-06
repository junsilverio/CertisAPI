using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class OrderMaster
    {
        public OrderMaster()
        {
            OrderApprovalRequests = new HashSet<OrderApprovalRequest>();
            OrderDetailFromMas = new HashSet<OrderDetailFromMa>();
            OrderDetails = new HashSet<OrderDetail>();
            OrderTeamAllocations = new HashSet<OrderTeamAllocation>();
            OrderWorkflowHistories = new HashSet<OrderWorkflowHistory>();
            PackingLists = new HashSet<PackingList>();
            TransportMasters = new HashSet<TransportMaster>();
        }

        public int Id { get; set; }
        public int? OrderGroupId { get; set; }
        public string OrderNo { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDt { get; set; }
        public int BranchId { get; set; }
        public int? ContractId { get; set; }
        public int? ConfigurationId { get; set; }
        public DateTime ExpectedDeliveryDt { get; set; }
        public DateTime? ExpectedTimeFrom { get; set; }
        public DateTime? ExpectedTimeTo { get; set; }
        public int? NumberOfPacks { get; set; }
        public int? OrderedBy { get; set; }
        public string OrderSource { get; set; }
        public decimal? TotalAmount { get; set; }
        public string DeliveryContactName { get; set; }
        public string DeliveryContactNumber { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? Version { get; set; }
        public int? TemplateId { get; set; }
        public int? CollectionRefId { get; set; }
        public int? RescheduledFrom { get; set; }
        public DateTime? ReScheduledDt { get; set; }
        public int? OrderSeries { get; set; }
        public int? PickUpPoint { get; set; }
        public string BillingNo { get; set; }
        public int? OrderCustomerId { get; set; }
        public int? FunLocId { get; set; }
        public DateTime? PickupTimeFrom { get; set; }
        public DateTime? PickupTimeTo { get; set; }
        public int? IsVaultDelivery { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual CollectionOrderMaster CollectionRef { get; set; }
        public virtual BranchConfiguration Configuration { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual OrderGroup OrderGroup { get; set; }
        public virtual Template Template { get; set; }
        public virtual ICollection<OrderApprovalRequest> OrderApprovalRequests { get; set; }
        public virtual ICollection<OrderDetailFromMa> OrderDetailFromMas { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<OrderTeamAllocation> OrderTeamAllocations { get; set; }
        public virtual ICollection<OrderWorkflowHistory> OrderWorkflowHistories { get; set; }
        public virtual ICollection<PackingList> PackingLists { get; set; }
        public virtual ICollection<TransportMaster> TransportMasters { get; set; }
    }
}
