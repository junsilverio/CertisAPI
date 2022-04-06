using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerSetting
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public bool CanEditDeno { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
