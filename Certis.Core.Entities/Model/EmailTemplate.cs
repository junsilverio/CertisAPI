using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EmailTemplate
    {
        public EmailTemplate()
        {
            EmailActivityLogs = new HashSet<EmailActivityLog>();
        }

        public int Id { get; set; }
        public string TemplateCode { get; set; }
        public string TemplateName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<EmailActivityLog> EmailActivityLogs { get; set; }
    }
}
