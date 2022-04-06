using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CollectionBoxDeno
    {
        public int Id { get; set; }
        public int CollectionPackTypeConfigId { get; set; }
        public int ProductId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual CollectionPackTypeConfig CollectionPackTypeConfig { get; set; }
        public virtual Product Product { get; set; }
    }
}
