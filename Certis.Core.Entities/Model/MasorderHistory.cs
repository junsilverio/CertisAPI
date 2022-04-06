using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasorderHistory
    {
        public int Id { get; set; }
        public int? MasorderId { get; set; }
        public int? StatusId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual MasterReferenceDatum Status { get; set; }
    }
}
