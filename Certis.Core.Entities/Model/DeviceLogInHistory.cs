using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DeviceLogInHistory
    {
        public int Id { get; set; }
        public string DeviceId { get; set; }
        public bool IsMc45 { get; set; }
        public DateTime? LoginDt { get; set; }
        public string Token { get; set; }
        public int? UserId { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual User User { get; set; }
    }
}
