using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerCollectionMode
    {
        public int? Slno { get; set; }
        public string CustomerName { get; set; }
        public string Bag { get; set; }
        public string Box { get; set; }
        public string Envelopes { get; set; }
        public string Envelopesinbags { get; set; }
        public string Pallets { get; set; }
        public string Coinbag { get; set; }
        public string Escort { get; set; }
        public string Allowdeddenominations { get; set; }
    }
}
