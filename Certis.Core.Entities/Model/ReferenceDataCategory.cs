using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ReferenceDataCategory
    {
        public ReferenceDataCategory()
        {
            MasterReferenceData = new HashSet<MasterReferenceDatum>();
        }

        public int Id { get; set; }
        public string CategoryCd { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryOwner { get; set; }
        public bool? IsProtected { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<MasterReferenceDatum> MasterReferenceData { get; set; }
    }
}
