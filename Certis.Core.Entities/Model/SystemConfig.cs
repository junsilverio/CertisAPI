using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SystemConfig
    {
        public int Id { get; set; }
        public string AccessKey { get; set; }
        public string Value { get; set; }
    }
}
