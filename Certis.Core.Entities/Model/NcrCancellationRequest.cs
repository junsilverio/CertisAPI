using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class NcrCancellationRequest
    {
        public int Id { get; set; }
        public int? TransportId { get; set; }
        public DateTime? RequestedDt { get; set; }
        public string Status { get; set; }
        public int? BankId { get; set; }
        public string ContactNo { get; set; }
        public string AccountNumber { get; set; }
        public string Remarks { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public bool? IsDeleted { get; set; }
        public bool IsRefundable { get; set; }
        public string CancellationReason { get; set; }
    }
}
