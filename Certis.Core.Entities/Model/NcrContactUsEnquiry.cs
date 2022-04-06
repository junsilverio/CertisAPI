using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class NcrContactUsEnquiry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string EnquiryType { get; set; }
        public string EnquiryMessage { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
