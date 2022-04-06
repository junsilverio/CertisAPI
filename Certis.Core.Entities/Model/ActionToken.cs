using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ActionToken
    {
        public int Id { get; set; }
        public int? ReferenceId { get; set; }
        public string Type { get; set; }
        public string Token { get; set; }
        public DateTime? CreateDt { get; set; }
        public string Status { get; set; }
    }
}
