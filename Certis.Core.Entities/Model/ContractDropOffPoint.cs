using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class ContractDropOffPoint
    {
        public int Id { get; set; }
        public int? ContractId { get; set; }
        public int? DropOffId { get; set; }
    }
}
