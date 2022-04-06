using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Bank
    {
        public Bank()
        {
            CustomerBankDetails = new HashSet<CustomerBankDetail>();
            RegistrationHistories = new HashSet<RegistrationHistory>();
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string BankName { get; set; }
        public int? AccountNoFormat { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<CustomerBankDetail> CustomerBankDetails { get; set; }
        public virtual ICollection<RegistrationHistory> RegistrationHistories { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
