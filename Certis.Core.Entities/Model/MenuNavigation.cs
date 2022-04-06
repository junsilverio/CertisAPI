using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class MenuNavigation
    {
        public MenuNavigation()
        {
            InverseParent = new HashSet<MenuNavigation>();
        }

        public int Id { get; set; }
        public string MenuTitle { get; set; }
        public string Iconpath { get; set; }
        public int? MenuOrder { get; set; }
        public string Url { get; set; }
        public int? ParentId { get; set; }
        public string SystemName { get; set; }
        public bool IsDeleted { get; set; }
        public string Application { get; set; }

        public virtual MenuNavigation Parent { get; set; }
        public virtual ICollection<MenuNavigation> InverseParent { get; set; }
    }
}
