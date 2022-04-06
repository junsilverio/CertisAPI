using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DashBoardComponentBackup
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public string AccessCode { get; set; }
        public string Application { get; set; }
        public string Remarks { get; set; }
        public string DefaultType { get; set; }
        public string AdditionalTypes { get; set; }
        public string SourceQuery { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public string CssClass { get; set; }
        public string XAxis { get; set; }
        public string YAxis { get; set; }
        public string ZAxis { get; set; }
        public string RedirectUrl { get; set; }
        public string BgColor { get; set; }
        public bool? IsPrimary { get; set; }
        public int? DetailId { get; set; }
    }
}
