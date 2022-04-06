using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class SavedQuery
    {
        public int Id { get; set; }
        public string QueryName { get; set; }
        public string Query { get; set; }
        public bool? IsAggregate { get; set; }
    }
}
