using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EmailGroup1
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string AccessCode { get; set; }
        public string Recipients { get; set; }
        public string Ccrecipients { get; set; }
        public string EmailBody { get; set; }
        public string Subject { get; set; }
    }
}
