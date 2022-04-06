using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Consumable
    {
        public int Id { get; set; }
        public int? BranchId { get; set; }
        public DateTime? Date { get; set; }
        public string Consumables { get; set; }
        public bool IsDeleted { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
