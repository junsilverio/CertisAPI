using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class RegistrationHistory
    {
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int ReqSubscriptionTypeId { get; set; }
        public int? ApprovedSubscriptionTypeId { get; set; }
        public bool IsUpgrade { get; set; }
        public bool IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Remarks { get; set; }
        public int? BankId { get; set; }
        public string AccountNumber { get; set; }
        public string SubscriptionRefNumber { get; set; }
        public decimal? SubscriptionAmount { get; set; }
        public decimal? Gstamount { get; set; }
        public decimal? TotalSubscriptionAmount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public string GwHmac { get; set; }
        public bool? IsVarified { get; set; }
        public DateTime? PaymentDt { get; set; }
        public string SapreffNo { get; set; }
        public string AccountManager { get; set; }
        public decimal? GateWayProcessingCharge { get; set; }
        public string NetsTxnRef { get; set; }
        public string NetstxnRand { get; set; }
        public string InvoiceRefNo { get; set; }
        public string CustomerSapNo { get; set; }

        public virtual MasterReferenceDatum ApprovedSubscriptionType { get; set; }
        public virtual Bank Bank { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual MasterReferenceDatum ReqSubscriptionType { get; set; }
    }
}
