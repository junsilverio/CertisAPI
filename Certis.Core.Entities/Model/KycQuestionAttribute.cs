using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class KycQuestionAttribute
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        public string AnswerType { get; set; }
        public string CssClass { get; set; }
        public string IsMandotory { get; set; }
        public string AttributeName { get; set; }
        public string AttributeId { get; set; }
    }
}
