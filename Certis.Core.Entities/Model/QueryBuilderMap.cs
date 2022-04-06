using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class QueryBuilderMap
    {
        public int Id { get; set; }
        public string ObjectName { get; set; }
        public string Type { get; set; }
        public string Alias { get; set; }
        public bool? DeletedFg { get; set; }
        public string SchemaName { get; set; }
    }
}
