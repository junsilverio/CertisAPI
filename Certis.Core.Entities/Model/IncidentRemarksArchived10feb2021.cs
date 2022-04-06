using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class IncidentRemarksArchived10feb2021
    {
        public int Id { get; set; }
        public int Tdid { get; set; }
        public string Remarks { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
