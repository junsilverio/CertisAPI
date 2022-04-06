using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CollectionPackTypeConfig
    {
        public CollectionPackTypeConfig()
        {
            CollectionBoxDenos = new HashSet<CollectionBoxDeno>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public bool IsBagOnly { get; set; }
        public bool IsEnvelopsOnly { get; set; }
        public bool IsEnvelopsInBag { get; set; }
        public bool IsBoxes { get; set; }
        public bool? IsPallets { get; set; }
        public bool? IsCoinBox { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CollectionBoxDeno> CollectionBoxDenos { get; set; }
    }
}
