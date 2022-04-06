using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ExcelMapper
    {
        public ExcelMapper()
        {
            ExcelColumnMappers = new HashSet<ExcelColumnMapper>();
        }

        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? HeaderRow { get; set; }
        public int? DataRowStartIndex { get; set; }

        public virtual ICollection<ExcelColumnMapper> ExcelColumnMappers { get; set; }
    }
}
