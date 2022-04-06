using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SubscriptionServiceConfig
    {
        public int Id { get; set; }
        public int SubscriptionTypeId { get; set; }
        public int ServiceTypeId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual MasterReferenceDatum ServiceType { get; set; }
        public virtual MasterReferenceDatum SubscriptionType { get; set; }
    }
}
