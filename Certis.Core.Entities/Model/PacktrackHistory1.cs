using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PacktrackHistory1
    {
        public long Id { get; set; }
        public int? CollectionPackId { get; set; }
        public int? TransactionId { get; set; }
        public string TransactionType { get; set; }
        public string BranchName { get; set; }
        public string CustomerName { get; set; }
        public string CurrentOwner { get; set; }
        public string DestinationOwner { get; set; }
        public string ItemType { get; set; }
        public string SealNo { get; set; }
        public string SealNo2 { get; set; }
        public decimal? Deno { get; set; }
        public int? Qty { get; set; }
        public decimal? Amount { get; set; }
        public string CageId { get; set; }
        public string CageNo { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string LastModifiedUser { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public DateTime? HistoryDt { get; set; }
        public int? SourceId { get; set; }
        public int? DestinationId { get; set; }
    }
}
