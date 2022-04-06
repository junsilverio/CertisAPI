using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class TransportMasterLookUp
    {
        public int Id { get; set; }
        public string VersionNo { get; set; }
        public string JobNo { get; set; }
        public string FunctionalCode { get; set; }
        public string BranchCode { get; set; }
        public string CustomerName { get; set; }
        public string ContactNumber { get; set; }
        public string JobType { get; set; }
        public int IsAdHoc { get; set; }
        public DateTime? JobStartDate { get; set; }
        public DateTime? JobEndDate { get; set; }
        public DateTime? DropStartDate { get; set; }
        public DateTime? DropEndDate { get; set; }
        public int TransactionTime { get; set; }
        public string Ppaddress { get; set; }
        public string Dpaddress { get; set; }
        public string PppostCode { get; set; }
        public string DppostCode { get; set; }
        public int? JobGroupId { get; set; }
        public string ForcedSequence { get; set; }
        public string BlockOffTimeStart { get; set; }
        public string BlockOffTimeEnd { get; set; }
        public string RequiredVehicleType { get; set; }
        public string EstimatedCash { get; set; }
        public string ExistingVehicle { get; set; }
        public string ExistingSequence { get; set; }
        public string Remarks { get; set; }
        public string ItemTobeWithdrawn { get; set; }
        public string CodeForDropOffPoint { get; set; }
        public string Pcs { get; set; }
        public string CollectionMode { get; set; }
        public string Signature { get; set; }
        public string JobTag { get; set; }
        public int? ExistingTeamId { get; set; }
        public string ExistingTeam { get; set; }
        public string DropOffType { get; set; }
        public DateTime? PEta { get; set; }
        public DateTime? DEta { get; set; }
        public string OrderType { get; set; }
        public string Mde { get; set; }
        public string OrderAction { get; set; }
        public string Cittype { get; set; }
        public string Citdetails { get; set; }
        public DateTime? OrderDt { get; set; }
    }
}
