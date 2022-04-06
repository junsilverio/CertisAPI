using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Announcement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime AnnouncementFromDt { get; set; }
        public DateTime AnnouncementToDt { get; set; }
        public byte[] Image { get; set; }
        public string ImageName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
