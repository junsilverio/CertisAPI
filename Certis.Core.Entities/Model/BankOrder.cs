using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BankOrder
    {
        public BankOrder()
        {
            BankOrderDetails = new HashSet<BankOrderDetail>();
        }

        public int Id { get; set; }
        public string OrderNo { get; set; }
        public DateTime OrderDt { get; set; }
        public int BranchId { get; set; }
        public int ContractId { get; set; }
        public int? ConfigurationId { get; set; }
        public DateTime ExpectedDeliveryDt { get; set; }
        public DateTime ExpectedTimeFrom { get; set; }
        public DateTime ExpectedTimeTo { get; set; }
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

        public virtual Branch Branch { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual ICollection<BankOrderDetail> BankOrderDetails { get; set; }
    }
}
