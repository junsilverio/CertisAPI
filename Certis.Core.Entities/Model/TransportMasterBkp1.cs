using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class TransportMasterBkp1
    {
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public int PickUpPoint { get; set; }
        public int DropOffPoint { get; set; }
        public DateTime? OrderDt { get; set; }
        public int? FloatDeliveryOrderId { get; set; }
        public int? CollectionOrderId { get; set; }
        public string Type { get; set; }
        public int? TeamId { get; set; }
        public string VersionNo { get; set; }
        public string SequenceNo { get; set; }
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
        public DateTime? PickUpEta { get; set; }
        public DateTime? DeliveryEta { get; set; }
        public bool? ReAssigned { get; set; }
        public string SapreffNo { get; set; }
        public string AccountManager { get; set; }
        public string InvoiceRefNo { get; set; }
        public string CustomerSapNo { get; set; }
    }
}
