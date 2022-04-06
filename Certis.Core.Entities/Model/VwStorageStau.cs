using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwStorageStau
    {
        public DateTime ScheduledDate { get; set; }
        public decimal? Total { get; set; }
        public decimal Price { get; set; }
        public decimal? Booked { get; set; }
        public decimal? Blocked { get; set; }
        public decimal? Availiable { get; set; }
        public decimal? AvailiableWithBlocked { get; set; }
        public decimal? InUse { get; set; }
        public decimal? CanRelease { get; set; }
    }
}
