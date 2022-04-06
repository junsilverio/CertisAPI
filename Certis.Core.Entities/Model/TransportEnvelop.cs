using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class TransportEnvelop
    {
        public int Id { get; set; }
        public int? DetailId { get; set; }
        public string SealNo { get; set; }

        public virtual TransportDetail Detail { get; set; }
    }
}
