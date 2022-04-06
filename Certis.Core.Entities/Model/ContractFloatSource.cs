using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ContractFloatSource
    {
        public int Id { get; set; }
        public int ContractId { get; set; }
        public int FloatSourceId { get; set; }
        public decimal? DepositAmount { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Contract Contract { get; set; }
        public virtual MasterReferenceDatum FloatSource { get; set; }
    }
}
