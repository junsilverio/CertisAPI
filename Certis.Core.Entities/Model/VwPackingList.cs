using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class VwPackingList
    {
        public int? OrderId { get; set; }
        public string SealNo { get; set; }
        public string EnvelopNo { get; set; }
    }
}
