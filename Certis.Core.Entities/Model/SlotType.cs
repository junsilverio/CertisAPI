using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SlotType
    {
        public int Id { get; set; }
        public string SlotType1 { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? Cittype { get; set; }

        public virtual MasterReferenceDatum CittypeNavigation { get; set; }
    }
}
