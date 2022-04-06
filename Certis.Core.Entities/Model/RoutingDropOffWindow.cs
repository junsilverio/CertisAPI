using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class RoutingDropOffWindow
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string MonStartWindow { get; set; }
        public string MonEndWindow { get; set; }
        public string TueStartWindow { get; set; }
        public string TueEndWindow { get; set; }
        public string WedStartWindow { get; set; }
        public string WedEndWindow { get; set; }
        public string ThuStartWindow { get; set; }
        public string ThuEndWindow { get; set; }
        public string FriStartWindow { get; set; }
        public string FriEndWindow { get; set; }
        public string SatStartWindow { get; set; }
        public string SatEndWindow { get; set; }
        public string SunStartWindow { get; set; }
        public string SunEndWindow { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
