using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasdepositOrder
    {
        public int Id { get; set; }
        public DateTime OrderDt { get; set; }
        public string OrderNo { get; set; }
        public int CustomerId { get; set; }
        public int CurrencyTypeId { get; set; }
        public int CurrencyId { get; set; }
        public int? CategoryId { get; set; }
        public int SeriesId { get; set; }
        public decimal Amount { get; set; }
        public int? Piece { get; set; }
        public int Stack { get; set; }
        public int? Bundle { get; set; }
        public int Box { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsDelivered { get; set; }

        public virtual MasterReferenceDatum Category { get; set; }
        public virtual Product Currency { get; set; }
        public virtual MasterReferenceDatum CurrencyType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual MasterReferenceDatum Series { get; set; }
    }
}
