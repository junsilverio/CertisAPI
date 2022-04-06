using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwBranchAddress
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string FunctionalCode { get; set; }
        public string StreetName { get; set; }
        public string Tower { get; set; }
        public string Town { get; set; }
        public string PinCode { get; set; }
        public int CustomerId { get; set; }
    }
}
