using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PrintReceiptSetting
    {
        public byte[] Logo { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
    }
}
