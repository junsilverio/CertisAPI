using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasformsSetting
    {
        public int Id { get; set; }
        public int? FormId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public int? CategoryId { get; set; }
        public int? SeriesId { get; set; }
        public int? ProductId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public int? ParentCategoryId { get; set; }
        public bool? CanByPieice { get; set; }
        public bool? CanByRollOrStack { get; set; }
        public int? CanByBundle { get; set; }

        public virtual MasterReferenceDatum Category { get; set; }
        public virtual MasterReferenceDatum CurrencyType { get; set; }
        public virtual MasterReferenceDatum Form { get; set; }
        public virtual Product Product { get; set; }
        public virtual MasterReferenceDatum Series { get; set; }
    }
}
