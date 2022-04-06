using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ExcelColumnMapper
    {
        public int Id { get; set; }
        public int? MapperId { get; set; }
        public int? ColIndex { get; set; }
        public string MapAttribute { get; set; }
        public int? DenoId { get; set; }

        public virtual ExcelMapper Mapper { get; set; }
    }
}
