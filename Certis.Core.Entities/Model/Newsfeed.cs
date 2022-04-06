using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Newsfeed
    {
        public int Id { get; set; }
        public string Notification { get; set; }
        public int? SendTo { get; set; }
        public bool? ReadStatus { get; set; }
        public DateTime? SentOn { get; set; }
        public string RedirectUrl { get; set; }
        public string Module { get; set; }
    }
}
