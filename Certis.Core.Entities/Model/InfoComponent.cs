using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class InfoComponent
    {
        public int Id { get; set; }
        public string AccessCode { get; set; }
        public string SourceQuery { get; set; }
    }
}
