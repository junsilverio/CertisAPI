using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class BranchConfiguration
    {
        public BranchConfiguration()
        {
            BranchConfigCollectionDetails = new HashSet<BranchConfigCollectionDetail>();
            BranchConfigDropOffPoints = new HashSet<BranchConfigDropOffPoint>();
            FloatDeliverySettings = new HashSet<FloatDeliverySetting>();
            OrderMasters = new HashSet<OrderMaster>();
        }

        public int Id { get; set; }
        public int? BranchId { get; set; }
        public int? ContractId { get; set; }
        public int ServiceTypeId { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual Contract Contract { get; set; }
        public virtual MasterReferenceDatum ServiceType { get; set; }
        public virtual ICollection<BranchConfigCollectionDetail> BranchConfigCollectionDetails { get; set; }
        public virtual ICollection<BranchConfigDropOffPoint> BranchConfigDropOffPoints { get; set; }
        public virtual ICollection<FloatDeliverySetting> FloatDeliverySettings { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
    }
}
