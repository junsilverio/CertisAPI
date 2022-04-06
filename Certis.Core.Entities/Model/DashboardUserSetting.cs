using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DashboardUserSetting
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? DashboardComponentId { get; set; }
        public int? DisplayOrder { get; set; }
        public int? Xposition { get; set; }
        public int? Yposition { get; set; }
    }
}
