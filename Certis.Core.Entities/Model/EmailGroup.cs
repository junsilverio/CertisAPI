using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class EmailGroup
    {
        public int Id { get; set; }
        public int? GroupId { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public string EmailId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
