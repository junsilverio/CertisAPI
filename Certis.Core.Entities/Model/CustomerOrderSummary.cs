using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerOrderSummary
    {
        public CustomerOrderSummary()
        {
            CustomerFeedbacks = new HashSet<CustomerFeedback>();
            CustomerOrderTransactions = new HashSet<CustomerOrderTransaction>();
            InverseParentOrder = new HashSet<CustomerOrderSummary>();
            OrderStorages = new HashSet<OrderStorage>();
        }

        public int Id { get; set; }
        public string OrderReferenceNumber { get; set; }
        public int NonCertisServiceTypeId { get; set; }
        public int CustomerId { get; set; }
        public int? CustomerUserId { get; set; }
        public int PickupOrderId { get; set; }
        public int? DeliveryOrderId { get; set; }
        public int PickupSlotId { get; set; }
        public int? DeliverySlotId { get; set; }
        public int? NumberOfPackages { get; set; }
        public decimal? PackageWeight { get; set; }
        public decimal? PackageLength { get; set; }
        public decimal? PackageWidth { get; set; }
        public decimal? PackageHeight { get; set; }
        public decimal? PickUpCharge { get; set; }
        public decimal? DeliveryCharge { get; set; }
        public decimal DynamicCharge { get; set; }
        public decimal? StorageCharge { get; set; }
        public decimal? PostalCodeCharge { get; set; }
        public decimal? ItemCharge { get; set; }
        public decimal? CashProcessingCharge { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Gstamount { get; set; }
        public decimal GrandTotal { get; set; }
        public string Remarks { get; set; }
        public bool IsCancelled { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? ParentOrderId { get; set; }
        public decimal? StorageSize { get; set; }
        public string GwHmac { get; set; }
        public bool? IsVarified { get; set; }
        public DateTime? VarifiedTime { get; set; }
        public decimal? RefundAmount { get; set; }
        public DateTime? RefundDt { get; set; }
        public int? RefundRequestId { get; set; }
        public decimal? GateWayProcessingCharge { get; set; }
        public bool? ConfirmRefund { get; set; }
        public string NetsTxnRef { get; set; }
        public string NetstxnRand { get; set; }
        public string PaymentMode { get; set; }
        public string Token { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerUser CustomerUser { get; set; }
        public virtual Slot DeliverySlot { get; set; }
        public virtual MasterReferenceDatum NonCertisServiceType { get; set; }
        public virtual CustomerOrderSummary ParentOrder { get; set; }
        public virtual Slot PickupSlot { get; set; }
        public virtual ICollection<CustomerFeedback> CustomerFeedbacks { get; set; }
        public virtual ICollection<CustomerOrderTransaction> CustomerOrderTransactions { get; set; }
        public virtual ICollection<CustomerOrderSummary> InverseParentOrder { get; set; }
        public virtual ICollection<OrderStorage> OrderStorages { get; set; }
    }
}
