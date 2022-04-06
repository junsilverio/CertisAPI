using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class AgreementMaster
    {
        public int Id { get; set; }
        public string AccessName { get; set; }
        public string AggrementText { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DisplayOrder { get; set; }
        public int CreatedBy { get; set; }
        public DateTime Createddt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
    }
}
