using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasdepositOrderDetail
    {
        public int Id { get; set; }
        public int MasdepositOrderMasterId { get; set; }
        public int? CurrencyTypeId { get; set; }
        public int CurrencyId { get; set; }
        public int? CategoryId { get; set; }
        public int? FormId { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? SeriesId { get; set; }
        public decimal? Amount { get; set; }
        public int? Piece { get; set; }
        public int? Stack { get; set; }
        public int? Bundle { get; set; }
        public int? Box { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual MasterReferenceDatum Category { get; set; }
        public virtual Product Currency { get; set; }
        public virtual MasterReferenceDatum CurrencyType { get; set; }
        public virtual MasterReferenceDatum Form { get; set; }
        public virtual MasdepositOrderMaster MasdepositOrderMaster { get; set; }
        public virtual MasterReferenceDatum ParentCategory { get; set; }
        public virtual MasterReferenceDatum Series { get; set; }
    }
}
