using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class Role
    {
        public Role()
        {
            CollectionOrderApprovals = new HashSet<CollectionOrderApproval>();
            DropOffPointOwners = new HashSet<DropOffPointOwner>();
            EmailGroups = new HashSet<EmailGroup>();
            HandoverMappingApprovalOwnerRoles = new HashSet<HandoverMapping>();
            HandoverMappingDestinationRoleNavigations = new HashSet<HandoverMapping>();
            HandoverMappingSourceRoleNavigations = new HashSet<HandoverMapping>();
            MashandoverMappingApprovalOwnerRoles = new HashSet<MashandoverMapping>();
            MashandoverMappingDestinationRoleNavigations = new HashSet<MashandoverMapping>();
            MashandoverMappingSourceRoleNavigations = new HashSet<MashandoverMapping>();
            MaspackingLists = new HashSet<MaspackingList>();
            OrderApprovalRequests = new HashSet<OrderApprovalRequest>();
            PackMovementApprovalRequestRejectOwnerNavigations = new HashSet<PackMovementApprovalRequest>();
            PackMovementApprovalRequestRequestOwnerNavigations = new HashSet<PackMovementApprovalRequest>();
            PermissionRoles = new HashSet<PermissionRole>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string RoleName { get; set; }
        public string RoleCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? ParentId { get; set; }
        public bool? IsReadonly { get; set; }

        public virtual ICollection<CollectionOrderApproval> CollectionOrderApprovals { get; set; }
        public virtual ICollection<DropOffPointOwner> DropOffPointOwners { get; set; }
        public virtual ICollection<EmailGroup> EmailGroups { get; set; }
        public virtual ICollection<HandoverMapping> HandoverMappingApprovalOwnerRoles { get; set; }
        public virtual ICollection<HandoverMapping> HandoverMappingDestinationRoleNavigations { get; set; }
        public virtual ICollection<HandoverMapping> HandoverMappingSourceRoleNavigations { get; set; }
        public virtual ICollection<MashandoverMapping> MashandoverMappingApprovalOwnerRoles { get; set; }
        public virtual ICollection<MashandoverMapping> MashandoverMappingDestinationRoleNavigations { get; set; }
        public virtual ICollection<MashandoverMapping> MashandoverMappingSourceRoleNavigations { get; set; }
        public virtual ICollection<MaspackingList> MaspackingLists { get; set; }
        public virtual ICollection<OrderApprovalRequest> OrderApprovalRequests { get; set; }
        public virtual ICollection<PackMovementApprovalRequest> PackMovementApprovalRequestRejectOwnerNavigations { get; set; }
        public virtual ICollection<PackMovementApprovalRequest> PackMovementApprovalRequestRequestOwnerNavigations { get; set; }
        public virtual ICollection<PermissionRole> PermissionRoles { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
