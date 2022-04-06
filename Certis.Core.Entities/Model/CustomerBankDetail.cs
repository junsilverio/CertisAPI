using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerBankDetail
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int BankId { get; set; }
        public string AccountNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Bank Bank { get; set; }
    }
}
