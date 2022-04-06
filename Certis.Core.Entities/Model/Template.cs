using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Template
    {
        public Template()
        {
            BranchSchedules = new HashSet<BranchSchedule>();
            DayTemplates = new HashSet<DayTemplate>();
            FloatDeliverySettings = new HashSet<FloatDeliverySetting>();
            OrderMasters = new HashSet<OrderMaster>();
            TemplateBranches = new HashSet<TemplateBranch>();
            TemplateDetails = new HashSet<TemplateDetail>();
        }

        public int Id { get; set; }
        public string TemplateName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<BranchSchedule> BranchSchedules { get; set; }
        public virtual ICollection<DayTemplate> DayTemplates { get; set; }
        public virtual ICollection<FloatDeliverySetting> FloatDeliverySettings { get; set; }
        public virtual ICollection<OrderMaster> OrderMasters { get; set; }
        public virtual ICollection<TemplateBranch> TemplateBranches { get; set; }
        public virtual ICollection<TemplateDetail> TemplateDetails { get; set; }
    }
}
