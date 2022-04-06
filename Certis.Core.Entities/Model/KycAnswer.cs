using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class KycAnswer
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public string Answer { get; set; }
        public int CustomerId { get; set; }
        public DateTime? CreateDt { get; set; }
    }
}
