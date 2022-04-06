using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Mb
    {
        public int? Total { get; set; }
        public long? RowNo { get; set; }
        public int Id { get; set; }
        public string OrderNo { get; set; }
        public string FunctionalCode { get; set; }
        public string JobType { get; set; }
        public string CustomerName { get; set; }
        public string PickUpPointCode { get; set; }
        public string OperationDate { get; set; }
        public string OpertaionStartWindow { get; set; }
        public string OpertaionEndWindow { get; set; }
        public string ActualFromTime { get; set; }
        public string ActualToTime { get; set; }
        public string Duration { get; set; }
        public string TeamCode { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public string DropOffPointCode { get; set; }
        public bool? IsSigned { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public string JobStatus { get; set; }
        public string Deliverables { get; set; }
        public string DeviceId { get; set; }
        public bool? ReAssigned { get; set; }
        public string ReAssignHstry { get; set; }
        public string DownloadDt { get; set; }
        public bool? CancelRequested { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
    }
}
