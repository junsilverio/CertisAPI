using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Stuteam
    {
        public int Id { get; set; }
        public int TeamId { get; set; }
        public int? UserId { get; set; }
        public DateTime AssignDt { get; set; }
        public bool? IsSupervisor { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public DateTime? VehicleStartTime { get; set; }
        public DateTime? Break1StartTime { get; set; }
        public DateTime? Break1EndTime { get; set; }
        public DateTime? Break2StartTime { get; set; }
        public DateTime? Break2EndTime { get; set; }
        public bool? EnableManualEntry { get; set; }
        public int? GunManId { get; set; }
        public int? DriverId { get; set; }

        public virtual MasterReferenceDatum Team { get; set; }
        public virtual User User { get; set; }
    }
}
