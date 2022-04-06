using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class UserRememberMe
    {
        public int RegistrationId { get; set; }
        public string SeriesToken { get; set; }
        public string SeriesHash { get; set; }
        public bool? IsDeleted { get; set; }
        public int Id { get; set; }
    }
}
