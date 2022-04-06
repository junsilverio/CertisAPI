using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class NccBank
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string Remarks { get; set; }
        public int? AcnoMinDigit { get; set; }
        public int? AcnoMaxDigit { get; set; }
        public string Format { get; set; }
    }
}
