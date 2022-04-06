using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class CustomerRegistration
    {
        public int Id { get; set; }
        public string AcraNo { get; set; }
        public string CustomerName { get; set; }
        public int AddressId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ContactName { get; set; }
        public string ContactNo { get; set; }
        public DateTime RegisteredOn { get; set; }
        public int SubscriptionType { get; set; }
        public bool IsRegistrationCompleted { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }

        public virtual Address Address { get; set; }
        public virtual MasterReferenceDatum SubscriptionTypeNavigation { get; set; }
    }
}
