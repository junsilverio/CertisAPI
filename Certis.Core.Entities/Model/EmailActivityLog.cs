using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EmailActivityLog
    {
        public int Id { get; set; }
        public int? EmailTemplateId { get; set; }
        public int? RefrenceId { get; set; }
        public string Action { get; set; }
        public int SentToId { get; set; }
        public string EmailId { get; set; }
        public string Ccemail { get; set; }
        public string Content { get; set; }
        public DateTime SentDt { get; set; }
        public int SentById { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual EmailTemplate EmailTemplate { get; set; }
        public virtual User SentBy { get; set; }
        public virtual User SentTo { get; set; }
    }
}
