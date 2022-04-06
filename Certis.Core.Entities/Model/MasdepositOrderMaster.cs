using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MasdepositOrderMaster
    {
        public MasdepositOrderMaster()
        {
            MasdepositOrderDetails = new HashSet<MasdepositOrderDetail>();
            MastransportMasters = new HashSet<MastransportMaster>();
        }

        public int Id { get; set; }
        public DateTime OrderDt { get; set; }
        public string OrderNo { get; set; }
        public int CustomerId { get; set; }
        public int IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<MasdepositOrderDetail> MasdepositOrderDetails { get; set; }
        public virtual ICollection<MastransportMaster> MastransportMasters { get; set; }
    }
}
