using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SlotPricing
    {
        public SlotPricing()
        {
            SlotScheduleDetails = new HashSet<SlotScheduleDetail>();
        }

        public int Id { get; set; }
        public string PricingName { get; set; }
        public string SlotType { get; set; }
        public int? CitTypeId { get; set; }
        public decimal Price { get; set; }
        public decimal? MaximumPrice { get; set; }
        public decimal? DynamicIncrement { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsDefault { get; set; }
        public int? CutoffHours { get; set; }
        public int? CutoffInterval { get; set; }
        public string DynamicCalcType { get; set; }

        public virtual MasterReferenceDatum CitType { get; set; }
        public virtual ICollection<SlotScheduleDetail> SlotScheduleDetails { get; set; }
    }
}
