using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwScheduledDeliveryOrderPlaced
    {
        public int BranchId { get; set; }
        public DateTime? ScheduleDt { get; set; }
        public DateTime? OrderCuttOffDt { get; set; }
        public int ServiceTypeId { get; set; }
        public int IsOrderPlaced { get; set; }
    }
}
