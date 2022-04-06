using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Address
    {
        public Address()
        {
            Branches = new HashSet<Branch>();
            CustomerRegistrations = new HashSet<CustomerRegistration>();
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string StreetName { get; set; }
        public string Tower { get; set; }
        public string Town { get; set; }
        public string PinCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public string BuildingCode { get; set; }
        public string Floor { get; set; }
        public string Room { get; set; }
        public string BuildingName { get; set; }
        public string Street2 { get; set; }
        public string Street3 { get; set; }
        public string HouseNumber { get; set; }
        public string CityName { get; set; }
        public string Site { get; set; }
        public string DropoffDescription { get; set; }
        public string DropoffRemarks { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<CustomerRegistration> CustomerRegistrations { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
