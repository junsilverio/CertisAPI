using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class KycQuestion
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Questions { get; set; }
        public string InputType { get; set; }
        public bool? IsMandatory { get; set; }
        public int? DisplayOrder { get; set; }
        public string CssClass { get; set; }
        public string DataUrl { get; set; }
        public string DataSourceJson { get; set; }
        public int? ParentId { get; set; }
        public string ParentArgument { get; set; }
        public bool? RequiredTrigger { get; set; }
        public string TriggerArgument { get; set; }
        public string ValidationMessage { get; set; }
    }
}
