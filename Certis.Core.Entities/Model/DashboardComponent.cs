using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class DashboardComponent
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
        public string ColColor { get; set; }
        public string RowColor { get; set; }
        public string XAxis1 { get; set; }
        public string Ccolor { get; set; }
        public string Rcolor { get; set; }
        public bool IsDeleted { get; set; }
        public string PopUp { get; set; }
    }
}
