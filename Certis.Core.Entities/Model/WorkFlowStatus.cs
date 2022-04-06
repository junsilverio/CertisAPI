using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class WorkFlowStatus
    {
        public int Id { get; set; }
        public string StatusCode { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
    }
}
