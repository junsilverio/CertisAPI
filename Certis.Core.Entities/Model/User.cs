using System;
using System.Collections.Generic;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class User
    {
        public User()
        {
            Customers = new HashSet<Customer>();
            DeviceLogInHistories = new HashSet<DeviceLogInHistory>();
            EmailActivityLogSentBies = new HashSet<EmailActivityLog>();
            EmailActivityLogSentTos = new HashSet<EmailActivityLog>();
            EmailGroups = new HashSet<EmailGroup>();
            MasorderApprovalRequests = new HashSet<MasorderApprovalRequest>();
            OrderApprovalRequestApprovalOwners = new HashSet<OrderApprovalRequest>();
            OrderApprovalRequestRespondedBies = new HashSet<OrderApprovalRequest>();
            PackTracks = new HashSet<PackTrack>();
            Stuteams = new HashSet<Stuteam>();
            UserGroupUsers = new HashSet<UserGroupUser>();
            UserRoles = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public byte[] ProfileImage { get; set; }
        public int? TitleId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDt { get; set; }
        public bool IsDeleted { get; set; }

        public virtual MasterReferenceDatum Title { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DeviceLogInHistory> DeviceLogInHistories { get; set; }
        public virtual ICollection<EmailActivityLog> EmailActivityLogSentBies { get; set; }
        public virtual ICollection<EmailActivityLog> EmailActivityLogSentTos { get; set; }
        public virtual ICollection<EmailGroup> EmailGroups { get; set; }
        public virtual ICollection<MasorderApprovalRequest> MasorderApprovalRequests { get; set; }
        public virtual ICollection<OrderApprovalRequest> OrderApprovalRequestApprovalOwners { get; set; }
        public virtual ICollection<OrderApprovalRequest> OrderApprovalRequestRespondedBies { get; set; }
        public virtual ICollection<PackTrack> PackTracks { get; set; }
        public virtual ICollection<Stuteam> Stuteams { get; set; }
        public virtual ICollection<UserGroupUser> UserGroupUsers { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
