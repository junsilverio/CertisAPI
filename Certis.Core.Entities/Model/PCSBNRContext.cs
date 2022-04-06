using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Certis.Core.Entities.Model
{
    public partial class PCSBNRContext : DbContext
    {
        public PCSBNRContext()
        {
        }

        public PCSBNRContext(DbContextOptions<PCSBNRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActionToken> ActionTokens { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AgreementMaster> AgreementMasters { get; set; }
        public virtual DbSet<Announcement> Announcements { get; set; }
        public virtual DbSet<Announcementtry> Announcementtries { get; set; }
        public virtual DbSet<AppLog> AppLogs { get; set; }
        public virtual DbSet<Atmteam> Atmteams { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankOrder> BankOrders { get; set; }
        public virtual DbSet<BankOrderDetail> BankOrderDetails { get; set; }
        public virtual DbSet<BkpTransportDetailsDuplicate> BkpTransportDetailsDuplicates { get; set; }
        public virtual DbSet<BoxAssignLog> BoxAssignLogs { get; set; }
        public virtual DbSet<BoxRequirement> BoxRequirements { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<BranchConfigCollectionDetail> BranchConfigCollectionDetails { get; set; }
        public virtual DbSet<BranchConfigDropOffPoint> BranchConfigDropOffPoints { get; set; }
        public virtual DbSet<BranchConfiguration> BranchConfigurations { get; set; }
        public virtual DbSet<BranchDropOffPoint> BranchDropOffPoints { get; set; }
        public virtual DbSet<BranchSchedule> BranchSchedules { get; set; }
        public virtual DbSet<BranchScheduleCollectionDetail> BranchScheduleCollectionDetails { get; set; }
        public virtual DbSet<BranchScheduleTeam> BranchScheduleTeams { get; set; }
        public virtual DbSet<BranchTransportSetting> BranchTransportSettings { get; set; }
        public virtual DbSet<BranchVault> BranchVaults { get; set; }
        public virtual DbSet<CashCreditingDetail> CashCreditingDetails { get; set; }
        public virtual DbSet<CertisSite> CertisSites { get; set; }
        public virtual DbSet<CollectionBoxDeno> CollectionBoxDenos { get; set; }
        public virtual DbSet<CollectionOrderApproval> CollectionOrderApprovals { get; set; }
        public virtual DbSet<CollectionOrderDetail> CollectionOrderDetails { get; set; }
        public virtual DbSet<CollectionOrderMaster> CollectionOrderMasters { get; set; }
        public virtual DbSet<CollectionPackTypeConfig> CollectionPackTypeConfigs { get; set; }
        public virtual DbSet<Consumable> Consumables { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractApprovalRule> ContractApprovalRules { get; set; }
        public virtual DbSet<ContractAttribute> ContractAttributes { get; set; }
        public virtual DbSet<ContractAttributeValue> ContractAttributeValues { get; set; }
        public virtual DbSet<ContractDropOffPoint> ContractDropOffPoints { get; set; }
        public virtual DbSet<ContractFloatSource> ContractFloatSources { get; set; }
        public virtual DbSet<ContractServiceType> ContractServiceTypes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerBankDetail> CustomerBankDetails { get; set; }
        public virtual DbSet<CustomerBlacklist> CustomerBlacklists { get; set; }
        public virtual DbSet<CustomerCollectionMode> CustomerCollectionModes { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<CustomerFeedback> CustomerFeedbacks { get; set; }
        public virtual DbSet<CustomerOrderSummary> CustomerOrderSummaries { get; set; }
        public virtual DbSet<CustomerOrderTransaction> CustomerOrderTransactions { get; set; }
        public virtual DbSet<CustomerProduct> CustomerProducts { get; set; }
        public virtual DbSet<CustomerRegistration> CustomerRegistrations { get; set; }
        public virtual DbSet<CustomerSetting> CustomerSettings { get; set; }
        public virtual DbSet<CustomerUser> CustomerUsers { get; set; }
        public virtual DbSet<CustomerUserBranch> CustomerUserBranches { get; set; }
        public virtual DbSet<DashBoardComponentBackup> DashBoardComponentBackups { get; set; }
        public virtual DbSet<DashboardComponent> DashboardComponents { get; set; }
        public virtual DbSet<DashboardUserSetting> DashboardUserSettings { get; set; }
        public virtual DbSet<DayTemplate> DayTemplates { get; set; }
        public virtual DbSet<DeviceLogInHistory> DeviceLogInHistories { get; set; }
        public virtual DbSet<DevicePermissionRequest> DevicePermissionRequests { get; set; }
        public virtual DbSet<DisabledBranch> DisabledBranches { get; set; }
        public virtual DbSet<DropOffPointOwner> DropOffPointOwners { get; set; }
        public virtual DbSet<EmailActivityLog> EmailActivityLogs { get; set; }
        public virtual DbSet<EmailEvent> EmailEvents { get; set; }
        public virtual DbSet<EmailGroup> EmailGroups { get; set; }
        public virtual DbSet<EmailGroup1> EmailGroups1 { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }
        public virtual DbSet<EntityActivityLog> EntityActivityLogs { get; set; }
        public virtual DbSet<EscortOrderMaster> EscortOrderMasters { get; set; }
        public virtual DbSet<ExcelColumnMapper> ExcelColumnMappers { get; set; }
        public virtual DbSet<ExcelMapper> ExcelMappers { get; set; }
        public virtual DbSet<FloatDeliveryReScheduleRequest> FloatDeliveryReScheduleRequests { get; set; }
        public virtual DbSet<FloatDeliverySetting> FloatDeliverySettings { get; set; }
        public virtual DbSet<HandoverBranchMapping> HandoverBranchMappings { get; set; }
        public virtual DbSet<HandoverMapping> HandoverMappings { get; set; }
        public virtual DbSet<Holiday> Holidays { get; set; }
        public virtual DbSet<IncidentRemark> IncidentRemarks { get; set; }
        public virtual DbSet<IncidentRemarksArchived10feb2021> IncidentRemarksArchived10feb2021s { get; set; }
        public virtual DbSet<InfoComponent> InfoComponents { get; set; }
        public virtual DbSet<InternalHandoverLog> InternalHandoverLogs { get; set; }
        public virtual DbSet<InventoryAccount> InventoryAccounts { get; set; }
        public virtual DbSet<InventoryAudit> InventoryAudits { get; set; }
        public virtual DbSet<KycAnswer> KycAnswers { get; set; }
        public virtual DbSet<KycCategory> KycCategories { get; set; }
        public virtual DbSet<KycOption> KycOptions { get; set; }
        public virtual DbSet<KycQuestion> KycQuestions { get; set; }
        public virtual DbSet<KycQuestionAttribute> KycQuestionAttributes { get; set; }
        public virtual DbSet<MasdepositOrder> MasdepositOrders { get; set; }
        public virtual DbSet<MasdepositOrderDetail> MasdepositOrderDetails { get; set; }
        public virtual DbSet<MasdepositOrderMaster> MasdepositOrderMasters { get; set; }
        public virtual DbSet<MasenvelopsHistory> MasenvelopsHistories { get; set; }
        public virtual DbSet<MasformMaster> MasformMasters { get; set; }
        public virtual DbSet<MasformsSetting> MasformsSettings { get; set; }
        public virtual DbSet<MashandoverMapping> MashandoverMappings { get; set; }
        public virtual DbSet<MasorderApprovalRequest> MasorderApprovalRequests { get; set; }
        public virtual DbSet<MasorderHistory> MasorderHistories { get; set; }
        public virtual DbSet<MaspackMovementApprovalRequest> MaspackMovementApprovalRequests { get; set; }
        public virtual DbSet<MaspackingList> MaspackingLists { get; set; }
        public virtual DbSet<MasterReferenceDatum> MasterReferenceData { get; set; }
        public virtual DbSet<MastransportMaster> MastransportMasters { get; set; }
        public virtual DbSet<Mb> Mbs { get; set; }
        public virtual DbSet<MenuNavigation> MenuNavigations { get; set; }
        public virtual DbSet<MobileJobMessage> MobileJobMessages { get; set; }
        public virtual DbSet<NccBank> NccBanks { get; set; }
        public virtual DbSet<Ncctemplate> Ncctemplates { get; set; }
        public virtual DbSet<NcctemplateDetail> NcctemplateDetails { get; set; }
        public virtual DbSet<NcrCancellationRequest> NcrCancellationRequests { get; set; }
        public virtual DbSet<NcrContactUsEnquiry> NcrContactUsEnquiries { get; set; }
        public virtual DbSet<Newsfeed> Newsfeeds { get; set; }
        public virtual DbSet<NotificationGroup> NotificationGroups { get; set; }
        public virtual DbSet<NotificationRecipient> NotificationRecipients { get; set; }
        public virtual DbSet<NotifyByPermission> NotifyByPermissions { get; set; }
        public virtual DbSet<OrderApprovalRequest> OrderApprovalRequests { get; set; }
        public virtual DbSet<OrderApprovalRule> OrderApprovalRules { get; set; }
        public virtual DbSet<OrderApprovalRuleDetail> OrderApprovalRuleDetails { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderDetailFromMa> OrderDetailFromMas { get; set; }
        public virtual DbSet<OrderGroup> OrderGroups { get; set; }
        public virtual DbSet<OrderMaster> OrderMasters { get; set; }
        public virtual DbSet<OrderStorage> OrderStorages { get; set; }
        public virtual DbSet<OrderTeamAllocation> OrderTeamAllocations { get; set; }
        public virtual DbSet<OrderWorkflowFormValue> OrderWorkflowFormValues { get; set; }
        public virtual DbSet<OrderWorkflowHistory> OrderWorkflowHistories { get; set; }
        public virtual DbSet<PackMovementApprovalRequest> PackMovementApprovalRequests { get; set; }
        public virtual DbSet<PackMovementApprovalRequestArchived10feb2021> PackMovementApprovalRequestArchived10feb2021s { get; set; }
        public virtual DbSet<PackTrack> PackTracks { get; set; }
        public virtual DbSet<PackTrackArchived10feb2021> PackTrackArchived10feb2021s { get; set; }
        public virtual DbSet<PackTrackHistory> PackTrackHistories { get; set; }
        public virtual DbSet<PackingList> PackingLists { get; set; }
        public virtual DbSet<PacktrackHistory1> PacktrackHistory1s { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionAction> PermissionActions { get; set; }
        public virtual DbSet<PermissionRole> PermissionRoles { get; set; }
        public virtual DbSet<PostalCodeMaster> PostalCodeMasters { get; set; }
        public virtual DbSet<PrePackedBkp17032020> PrePackedBkp17032020s { get; set; }
        public virtual DbSet<PrintReceiptSetting> PrintReceiptSettings { get; set; }
        public virtual DbSet<ProcessingTransportId> ProcessingTransportIds { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<QueryBuilderMap> QueryBuilderMaps { get; set; }
        public virtual DbSet<ReferenceDataCategory> ReferenceDataCategories { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<RegistrationHistory> RegistrationHistories { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoutingDropOffWindow> RoutingDropOffWindows { get; set; }
        public virtual DbSet<S2sresponce> S2sresponces { get; set; }
        public virtual DbSet<SavedQuery> SavedQueries { get; set; }
        public virtual DbSet<ScheduleDetail> ScheduleDetails { get; set; }
        public virtual DbSet<ScheduleMaster> ScheduleMasters { get; set; }
        public virtual DbSet<ScheduledDate> ScheduledDates { get; set; }
        public virtual DbSet<SecurityDeposit> SecurityDeposits { get; set; }
        public virtual DbSet<Slot> Slots { get; set; }
        public virtual DbSet<SlotCustomer> SlotCustomers { get; set; }
        public virtual DbSet<SlotPricing> SlotPricings { get; set; }
        public virtual DbSet<SlotSchedule> SlotSchedules { get; set; }
        public virtual DbSet<SlotScheduleDetail> SlotScheduleDetails { get; set; }
        public virtual DbSet<SlotType> SlotTypes { get; set; }
        public virtual DbSet<Stuteam> Stuteams { get; set; }
        public virtual DbSet<SubscriptionServiceConfig> SubscriptionServiceConfigs { get; set; }
        public virtual DbSet<SystemActivityLog> SystemActivityLogs { get; set; }
        public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
        public virtual DbSet<SystemModule> SystemModules { get; set; }
        public virtual DbSet<TeamBreakLog> TeamBreakLogs { get; set; }
        public virtual DbSet<Template> Templates { get; set; }
        public virtual DbSet<TemplateBranch> TemplateBranches { get; set; }
        public virtual DbSet<TemplateDetail> TemplateDetails { get; set; }
        public virtual DbSet<TmpTimeUpdate> TmpTimeUpdates { get; set; }
        public virtual DbSet<TransportDetail> TransportDetails { get; set; }
        public virtual DbSet<TransportDetails12022020> TransportDetails12022020s { get; set; }
        public virtual DbSet<TransportDetails22012020> TransportDetails22012020s { get; set; }
        public virtual DbSet<TransportDetailsArchived10feb2021> TransportDetailsArchived10feb2021s { get; set; }
        public virtual DbSet<TransportDetailsBk12112020> TransportDetailsBk12112020s { get; set; }
        public virtual DbSet<TransportEnvelop> TransportEnvelops { get; set; }
        public virtual DbSet<TransportEnvelopArchived10feb2021> TransportEnvelopArchived10feb2021s { get; set; }
        public virtual DbSet<TransportMaster> TransportMasters { get; set; }
        public virtual DbSet<TransportMasterArchived10feb2021> TransportMasterArchived10feb2021s { get; set; }
        public virtual DbSet<TransportMasterBkp> TransportMasterBkps { get; set; }
        public virtual DbSet<TransportMasterBkp1> TransportMasterBkp1s { get; set; }
        public virtual DbSet<TransportMasterLookUp> TransportMasterLookUps { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAction> UserActions { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UserGroupUser> UserGroupUsers { get; set; }
        public virtual DbSet<UserRememberMe> UserRememberMes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VaultDeliveryInventoryAssignAudit> VaultDeliveryInventoryAssignAudits { get; set; }
        public virtual DbSet<VaultDeliveryItemDetail> VaultDeliveryItemDetails { get; set; }
        public virtual DbSet<VaultDeliveryTransportDetail> VaultDeliveryTransportDetails { get; set; }
        public virtual DbSet<VwApprovalLog> VwApprovalLogs { get; set; }
        public virtual DbSet<VwBranchAddress> VwBranchAddresses { get; set; }
        public virtual DbSet<VwCollectionApprovalLog> VwCollectionApprovalLogs { get; set; }
        public virtual DbSet<VwContactDetail> VwContactDetails { get; set; }
        public virtual DbSet<VwCurrencyProductAttribute> VwCurrencyProductAttributes { get; set; }
        public virtual DbSet<VwCustomerUserMapping> VwCustomerUserMappings { get; set; }
        public virtual DbSet<VwCustomerUserMappingOld> VwCustomerUserMappingOlds { get; set; }
        public virtual DbSet<VwOrderBagPackStatus> VwOrderBagPackStatuses { get; set; }
        public virtual DbSet<VwOrderWorkFlowStatus> VwOrderWorkFlowStatuses { get; set; }
        public virtual DbSet<VwPackTrack> VwPackTracks { get; set; }
        public virtual DbSet<VwPackingList> VwPackingLists { get; set; }
        public virtual DbSet<VwRoleHeirarchy> VwRoleHeirarchies { get; set; }
        public virtual DbSet<VwScheduledDeliveryOrderPlaced> VwScheduledDeliveryOrderPlaceds { get; set; }
        public virtual DbSet<VwStorageStau> VwStorageStaus { get; set; }
        public virtual DbSet<VwTransportStatus> VwTransportStatuses { get; set; }
        public virtual DbSet<VwVaultDeliveryOrder> VwVaultDeliveryOrders { get; set; }
        public virtual DbSet<WorkFlowMaster> WorkFlowMasters { get; set; }
        public virtual DbSet<WorkFlowStatus> WorkFlowStatuses { get; set; }
        public virtual DbSet<WorkFlowStatusDetail> WorkFlowStatusDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ActionToken>(entity =>
            {
                entity.Property(e => e.CreateDt).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Token).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.BuildingCode).HasMaxLength(25);

                entity.Property(e => e.BuildingName).HasMaxLength(50);

                entity.Property(e => e.CityName).HasMaxLength(255);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DropoffDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DropoffRemarks)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Floor).HasMaxLength(12);

                entity.Property(e => e.HouseNumber).HasMaxLength(255);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.PinCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Room).HasMaxLength(12);

                entity.Property(e => e.Site)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Street2).HasMaxLength(255);

                entity.Property(e => e.Street3).HasMaxLength(255);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tower)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgreementMaster>(entity =>
            {
                entity.ToTable("AgreementMaster");

                entity.Property(e => e.AccessName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Createddt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.ToTable("Announcement");

                entity.Property(e => e.AnnouncementFromDt).HasColumnType("datetime");

                entity.Property(e => e.AnnouncementToDt).HasColumnType("datetime");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Announcementtry>(entity =>
            {
                entity.ToTable("Announcementtry");

                entity.Property(e => e.AnnouncementFromDt).HasColumnType("datetime");

                entity.Property(e => e.AnnouncementToDt).HasColumnType("datetime");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AppLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Atmteam>(entity =>
            {
                entity.ToTable("ATMTeam");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("Bank");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<BankOrder>(entity =>
            {
                entity.ToTable("BankOrder");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryContactNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedDeliveryDt).HasColumnType("datetime");

                entity.Property(e => e.ExpectedTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.ExpectedTimeTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BankOrders)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.BankOrders)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BankOrderDetail>(entity =>
            {
                entity.ToTable("BankOrderDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.BankOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.BankOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BkpTransportDetailsDuplicate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BKP_TransportDetailsDuplicate");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BoxAssignLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BoxAssignLog");

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType).IsUnicode(false);

                entity.Property(e => e.Seal).IsUnicode(false);

                entity.Property(e => e.Site).IsUnicode(false);

                entity.Property(e => e.ToSite).IsUnicode(false);
            });

            modelBuilder.Entity<BoxRequirement>(entity =>
            {
                entity.Property(e => e.ActualAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssignedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("Branch");

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.BranchNumber)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.FunctionalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsTemporaryDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.HasOne(d => d.BranchAddress)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.BranchAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContact_Address_BranchAddressId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Branches)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BranchConfigCollectionDetail>(entity =>
            {
                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.BranchConfiguration)
                    .WithMany(p => p.BranchConfigCollectionDetails)
                    .HasForeignKey(d => d.BranchConfigurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BranchCon__Branc__11571710");
            });

            modelBuilder.Entity<BranchConfigDropOffPoint>(entity =>
            {
                entity.HasOne(d => d.BranchConfig)
                    .WithMany(p => p.BranchConfigDropOffPoints)
                    .HasForeignKey(d => d.BranchConfigId)
                    .HasConstraintName("FK_BranchConfigDropOffPoints_BranchConfigId");

                entity.HasOne(d => d.DropOffPoint)
                    .WithMany(p => p.BranchConfigDropOffPoints)
                    .HasForeignKey(d => d.DropOffPointId)
                    .HasConstraintName("FK_BranchConfigDropOffPoints_DropOffPointId");
            });

            modelBuilder.Entity<BranchConfiguration>(entity =>
            {
                entity.ToTable("BranchConfiguration");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EndDt).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.StartDt).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchConfigurations)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.BranchConfigurations)
                    .HasForeignKey(d => d.ContractId);

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.BranchConfigurations)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchConfiguration_MasterReferenceData");
            });

            modelBuilder.Entity<BranchDropOffPoint>(entity =>
            {
                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchDropOffPointBranches)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BranchDropOffPoints_BranchId");

                entity.HasOne(d => d.DropOff)
                    .WithMany(p => p.BranchDropOffPointDropOffs)
                    .HasForeignKey(d => d.DropOffId)
                    .HasConstraintName("FK_BranchDropOffPoints_DropOffId");
            });

            modelBuilder.Entity<BranchSchedule>(entity =>
            {
                entity.ToTable("BranchSchedule");

                entity.Property(e => e.BillingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EndDt).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Ph).HasColumnName("PH");

                entity.Property(e => e.ServiceTypeId).HasDefaultValueSql("((80))");

                entity.Property(e => e.StartDt).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Wknd).HasColumnName("WKND");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchSchedules)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.BranchSchedules)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ScheduleMaster)
                    .WithMany(p => p.BranchSchedules)
                    .HasForeignKey(d => d.ScheduleMasterId)
                    .HasConstraintName("FK_BranchSchedule_ScheduleMasterId");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.BranchSchedules)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.BranchSchedules)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_BranchSchedule_Template");
            });

            modelBuilder.Entity<BranchScheduleCollectionDetail>(entity =>
            {
                entity.Property(e => e.BillingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ClientInstruction).IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryFromTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryToTime).HasColumnType("datetime");

                entity.Property(e => e.FromTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Ph).HasColumnName("PH");

                entity.Property(e => e.ToTime).HasColumnType("datetime");

                entity.Property(e => e.Wknd).HasColumnName("WKND");

                entity.HasOne(d => d.BranchSchedule)
                    .WithMany(p => p.BranchScheduleCollectionDetails)
                    .HasForeignKey(d => d.BranchScheduleId)
                    .HasConstraintName("FK_BranchScheduleId");

                entity.HasOne(d => d.DropOffPointNavigation)
                    .WithMany(p => p.BranchScheduleCollectionDetails)
                    .HasForeignKey(d => d.DropOffPoint)
                    .HasConstraintName("FK_DropOffPoint");
            });

            modelBuilder.Entity<BranchScheduleTeam>(entity =>
            {
                entity.ToTable("BranchScheduleTeam");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.BranchScheduleTeams)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchScheduleTeam_BranchScheduleTeam");
            });

            modelBuilder.Entity<BranchTransportSetting>(entity =>
            {
                entity.Property(e => e.BlockEndTime).HasColumnType("datetime");

                entity.Property(e => e.BlockStartTime).HasColumnType("datetime");

                entity.Property(e => e.Citdetails)
                    .IsUnicode(false)
                    .HasColumnName("CITDetails");

                entity.Property(e => e.Cittype)
                    .IsUnicode(false)
                    .HasColumnName("CITType");

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedCash)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobTag).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.BranchTransportSettings)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_BranchTransportSettings_BranchId");
            });

            modelBuilder.Entity<BranchVault>(entity =>
            {
                entity.ToTable("BranchVault");

                entity.HasIndex(e => new { e.BranchId, e.VaultId }, "UNQ_BranchVault")
                    .IsUnique();
            });

            modelBuilder.Entity<CashCreditingDetail>(entity =>
            {
                entity.Property(e => e.AccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditedAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<CertisSite>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CollectionBoxDeno>(entity =>
            {
                entity.ToTable("CollectionBoxDeno");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.CollectionPackTypeConfig)
                    .WithMany(p => p.CollectionBoxDenos)
                    .HasForeignKey(d => d.CollectionPackTypeConfigId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Collectio__Colle__758D6A5C");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CollectionBoxDenos)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Collectio__Produ__7226EDCC");
            });

            modelBuilder.Entity<CollectionOrderApproval>(entity =>
            {
                entity.ToTable("CollectionOrderApproval");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Collection)
                    .WithMany(p => p.CollectionOrderApprovals)
                    .HasForeignKey(d => d.CollectionId)
                    .HasConstraintName("FK_CollectionOrderMaster_Id");

                entity.HasOne(d => d.OwnerRoleNavigation)
                    .WithMany(p => p.CollectionOrderApprovals)
                    .HasForeignKey(d => d.OwnerRole)
                    .HasConstraintName("FK_CollectionOrderApproval_OwnerRole");
            });

            modelBuilder.Entity<CollectionOrderDetail>(entity =>
            {
                entity.ToTable("CollectionOrderDetail");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.CollectionOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CollectionOrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CollectionOrderMaster>(entity =>
            {
                entity.ToTable("CollectionOrderMaster");

                entity.HasIndex(e => new { e.BranchId, e.DropOffPoint, e.IsDeleted, e.OrderDt }, "CollectionMaster_Index");

                entity.HasIndex(e => e.OrderNo, "INDX_CollectionOrderMaster_OrderNo");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BillingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionFromTime).HasColumnType("datetime");

                entity.Property(e => e.CollectionToTime).HasColumnType("datetime");

                entity.Property(e => e.Consumables)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("consumables");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeletedRemarks).IsUnicode(false);

                entity.Property(e => e.DeliveryFromTime).HasColumnType("datetime");

                entity.Property(e => e.DeliveryToTime).HasColumnType("datetime");

                entity.Property(e => e.DropoffDt).HasColumnType("datetime");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderAction)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('COLLECT')");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CollectionOrderMasterBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CollectionOrderMaster_BranchId");

                entity.HasOne(d => d.DropOffPointNavigation)
                    .WithMany(p => p.CollectionOrderMasterDropOffPointNavigations)
                    .HasForeignKey(d => d.DropOffPoint)
                    .HasConstraintName("FK__Collectio__DropO__51719C25");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.CollectionOrderMasters)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Collectio__TeamI__0E45A03B");
            });

            modelBuilder.Entity<CollectionPackTypeConfig>(entity =>
            {
                entity.ToTable("CollectionPackTypeConfig");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CollectionPackTypeConfigs)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Collectio__Custo__7A521F79");
            });

            modelBuilder.Entity<Consumable>(entity =>
            {
                entity.Property(e => e.Consumables)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.Property(e => e.ContractCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.SapidentificationCode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SAPIdentificationCode");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<ContractApprovalRule>(entity =>
            {
                entity.ToTable("ContractApprovalRule");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ContractApprovalRules)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_ContractApprovalRule_BranchId");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractApprovalRules)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractApprovalRule_ContractId");

                entity.HasOne(d => d.OrderApprovalRule)
                    .WithMany(p => p.ContractApprovalRules)
                    .HasForeignKey(d => d.OrderApprovalRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractApprovalRule_Contract_ContractId");
            });

            modelBuilder.Entity<ContractAttribute>(entity =>
            {
                entity.ToTable("ContractAttribute");

                entity.Property(e => e.ContractAttribute1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ContractAttribute");

                entity.Property(e => e.ContractAttributeCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<ContractAttributeValue>(entity =>
            {
                entity.ToTable("ContractAttributeValue");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ContractAttributeValues)
                    .HasForeignKey(d => d.AttributeId);

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractAttributeValues)
                    .HasForeignKey(d => d.ContractId);
            });

            modelBuilder.Entity<ContractDropOffPoint>(entity =>
            {
                entity.ToTable("ContractDropOffPoint");
            });

            modelBuilder.Entity<ContractFloatSource>(entity =>
            {
                entity.ToTable("ContractFloatSource");

                entity.Property(e => e.CreatedDt).HasColumnType("date");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastModifiedDt).HasColumnType("date");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractFloatSources)
                    .HasForeignKey(d => d.ContractId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractFloatSource_Contract");

                entity.HasOne(d => d.FloatSource)
                    .WithMany(p => p.ContractFloatSources)
                    .HasForeignKey(d => d.FloatSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractFloatSource_MasterReferenceData");
            });

            modelBuilder.Entity<ContractServiceType>(entity =>
            {
                entity.ToTable("ContractServiceType");

                entity.Property(e => e.CreatedDt).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.ContractServiceTypes)
                    .HasForeignKey(d => d.ContractId)
                    .HasConstraintName("FK_ContractServiceType_ContractServiceType");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.ActionRequired).HasDefaultValueSql("((0))");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.AccountManager)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountManagerId)
                    .HasConstraintName("FK_Customer_AccountManagerId");

                entity.HasOne(d => d.CustomerType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CustomerTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CustomerBankDetail>(entity =>
            {
                entity.ToTable("CustomerBankDetail");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.CustomerBankDetails)
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerBankDetail_Bank");
            });

            modelBuilder.Entity<CustomerBlacklist>(entity =>
            {
                entity.ToTable("CustomerBlacklist");

                entity.Property(e => e.AcraNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACRA_NO");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomerCollectionMode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_CollectionMode");

                entity.Property(e => e.Allowdeddenominations)
                    .HasMaxLength(255)
                    .HasColumnName("ALLOWDEDDENOMINATIONS ");

                entity.Property(e => e.Bag)
                    .HasMaxLength(255)
                    .HasColumnName("BAG");

                entity.Property(e => e.Box)
                    .HasMaxLength(255)
                    .HasColumnName("BOX");

                entity.Property(e => e.Coinbag)
                    .HasMaxLength(255)
                    .HasColumnName("COINBAG");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Envelopes)
                    .HasMaxLength(255)
                    .HasColumnName("ENVELOPES");

                entity.Property(e => e.Envelopesinbags)
                    .HasMaxLength(255)
                    .HasColumnName("ENVELOPESINBAGS");

                entity.Property(e => e.Escort)
                    .HasMaxLength(255)
                    .HasColumnName("ESCORT");

                entity.Property(e => e.Pallets)
                    .HasMaxLength(255)
                    .HasColumnName("PALLETS");

                entity.Property(e => e.Slno).HasColumnName("SLNo");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.ToTable("CustomerContact");

                entity.HasIndex(e => new { e.BranchId, e.IsDeleted }, "CustomerContact_Index");

                entity.Property(e => e.ContactDetail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<CustomerFeedback>(entity =>
            {
                entity.ToTable("CustomerFeedback");

                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerFeedbacks)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerFeedback_Customer");

                entity.HasOne(d => d.CustomerOrderSummary)
                    .WithMany(p => p.CustomerFeedbacks)
                    .HasForeignKey(d => d.CustomerOrderSummaryId)
                    .HasConstraintName("FK_CustomerFeedback_CustomerOrderSummary");
            });

            modelBuilder.Entity<CustomerOrderSummary>(entity =>
            {
                entity.ToTable("CustomerOrderSummary");

                entity.Property(e => e.CashProcessingCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DynamicCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GateWayProcessingCharge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.GrandTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gstamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSTAmount");

                entity.Property(e => e.GwHmac)
                    .HasMaxLength(100)
                    .HasColumnName("GW_HMAC");

                entity.Property(e => e.ItemCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.NetsTxnRef)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("netsTxnRef");

                entity.Property(e => e.NetstxnRand)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("netstxnRand");

                entity.Property(e => e.OrderReferenceNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PackageHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PackageWidth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PostalCodeCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RefundDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StorageCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StorageSize).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Token)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VarifiedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerOrderSummaries)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerOrderSummary_Customer");

                entity.HasOne(d => d.CustomerUser)
                    .WithMany(p => p.CustomerOrderSummaries)
                    .HasForeignKey(d => d.CustomerUserId)
                    .HasConstraintName("FK_CustomerOrderSummary_CustomerUser");

                entity.HasOne(d => d.DeliverySlot)
                    .WithMany(p => p.CustomerOrderSummaryDeliverySlots)
                    .HasForeignKey(d => d.DeliverySlotId)
                    .HasConstraintName("FK_CustomerOrderSummary_Slot1");

                entity.HasOne(d => d.NonCertisServiceType)
                    .WithMany(p => p.CustomerOrderSummaries)
                    .HasForeignKey(d => d.NonCertisServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerOrderSummary_MasterReferenceData");

                entity.HasOne(d => d.ParentOrder)
                    .WithMany(p => p.InverseParentOrder)
                    .HasForeignKey(d => d.ParentOrderId)
                    .HasConstraintName("FK_CustomerOrderSummary_CustomerOrderSummary");

                entity.HasOne(d => d.PickupSlot)
                    .WithMany(p => p.CustomerOrderSummaryPickupSlots)
                    .HasForeignKey(d => d.PickupSlotId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerOrderSummary_Slot");
            });

            modelBuilder.Entity<CustomerOrderTransaction>(entity =>
            {
                entity.ToTable("CustomerOrderTransaction");

                entity.Property(e => e.IsSuccess)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.ReferenceNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RefundRefNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CustomerOrderSummary)
                    .WithMany(p => p.CustomerOrderTransactions)
                    .HasForeignKey(d => d.CustomerOrderSummaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerOrderTransaction_CustomerOrderSummary");

                entity.HasOne(d => d.PaymentGateway)
                    .WithMany(p => p.CustomerOrderTransactions)
                    .HasForeignKey(d => d.PaymentGatewayId)
                    .HasConstraintName("FK_CustomerOrderTransaction_MasterReferenceData");
            });

            modelBuilder.Entity<CustomerProduct>(entity =>
            {
                entity.ToTable("CustomerProduct");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CustomerRegistration>(entity =>
            {
                entity.ToTable("CustomerRegistration");

                entity.Property(e => e.AcraNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ACRA_NO");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredOn).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.CustomerRegistrations)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRegistration_Address");

                entity.HasOne(d => d.SubscriptionTypeNavigation)
                    .WithMany(p => p.CustomerRegistrations)
                    .HasForeignKey(d => d.SubscriptionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerRegistration_MasterReferenceData");
            });

            modelBuilder.Entity<CustomerSetting>(entity =>
            {
                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerSettings)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerSettings_CustomerSettings");
            });

            modelBuilder.Entity<CustomerUser>(entity =>
            {
                entity.ToTable("CustomerUser");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CustomerUsers)
                    .HasForeignKey(d => d.BranchId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CustomerUserBranch>(entity =>
            {
                entity.ToTable("CustomerUserBranch");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.CustomerUserBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerUserBranch_BranchId");

                entity.HasOne(d => d.CustomerUser)
                    .WithMany(p => p.CustomerUserBranches)
                    .HasForeignKey(d => d.CustomerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerUserBranch_CustomerUserId");
            });

            modelBuilder.Entity<DashBoardComponentBackup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DashBoardComponentBackup");

                entity.Property(e => e.AccessCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalTypes)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.Application)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BgColor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CssClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SourceQuery).IsUnicode(false);

                entity.Property(e => e.XAxis)
                    .IsUnicode(false)
                    .HasColumnName("X_Axis");

                entity.Property(e => e.YAxis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Y_Axis");

                entity.Property(e => e.ZAxis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Z_Axis");
            });

            modelBuilder.Entity<DashboardComponent>(entity =>
            {
                entity.ToTable("DashboardComponent");

                entity.Property(e => e.AccessCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalTypes)
                    .HasMaxLength(550)
                    .IsUnicode(false);

                entity.Property(e => e.Application)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BgColor)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ccolor)
                    .IsUnicode(false)
                    .HasColumnName("CColor");

                entity.Property(e => e.ColColor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CssClass)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PopUp).IsUnicode(false);

                entity.Property(e => e.Rcolor)
                    .IsUnicode(false)
                    .HasColumnName("RColor");

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RowColor)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SourceQuery).IsUnicode(false);

                entity.Property(e => e.XAxis)
                    .IsUnicode(false)
                    .HasColumnName("X_Axis");

                entity.Property(e => e.XAxis1)
                    .IsUnicode(false)
                    .HasColumnName("X_Axis_1");

                entity.Property(e => e.YAxis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Y_Axis");

                entity.Property(e => e.ZAxis)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Z_Axis");
            });

            modelBuilder.Entity<DashboardUserSetting>(entity =>
            {
                entity.Property(e => e.Xposition).HasColumnName("XPosition");

                entity.Property(e => e.Yposition).HasColumnName("YPosition");
            });

            modelBuilder.Entity<DayTemplate>(entity =>
            {
                entity.ToTable("DayTemplate");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DayTemplates)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.DayTemplates)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DeviceLogInHistory>(entity =>
            {
                entity.ToTable("DeviceLogInHistory");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsMc45).HasColumnName("IsMC45");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.LoginDt).HasColumnType("datetime");

                entity.Property(e => e.Token)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DeviceLogInHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__STUTeamMa__UserI__36889BBF");
            });

            modelBuilder.Entity<DevicePermissionRequest>(entity =>
            {
                entity.ToTable("DevicePermissionRequest");

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FunLoc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Module)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RequestType).IsUnicode(false);

                entity.Property(e => e.RequestedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisabledBranch>(entity =>
            {
                entity.ToTable("DisabledBranch");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EndDt).HasColumnType("datetime");

                entity.Property(e => e.IsPermanentDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StartDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DisabledBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<DropOffPointOwner>(entity =>
            {
                entity.ToTable("DropOffPointOwner");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.DropOffPointOwners)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_DropOffPointOwner_BranchId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.DropOffPointOwners)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_DropOffPointOwner_RoleId");
            });

            modelBuilder.Entity<EmailActivityLog>(entity =>
            {
                entity.ToTable("EmailActivityLog");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ccemail)
                    .IsUnicode(false)
                    .HasColumnName("CCEmail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.SentDt).HasColumnType("datetime");

                entity.HasOne(d => d.EmailTemplate)
                    .WithMany(p => p.EmailActivityLogs)
                    .HasForeignKey(d => d.EmailTemplateId);

                entity.HasOne(d => d.SentBy)
                    .WithMany(p => p.EmailActivityLogSentBies)
                    .HasForeignKey(d => d.SentById)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SentTo)
                    .WithMany(p => p.EmailActivityLogSentTos)
                    .HasForeignKey(d => d.SentToId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmailEvent>(entity =>
            {
                entity.ToTable("EmailEvent");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EventName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmailGroup>(entity =>
            {
                entity.ToTable("EmailGroup");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.EmailGroups)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmailGroups)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<EmailGroup1>(entity =>
            {
                entity.ToTable("EmailGroups");

                entity.Property(e => e.AccessCode)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ccrecipients)
                    .IsUnicode(false)
                    .HasColumnName("CCRecipients");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recipients).IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.ToTable("EmailTemplate");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntityActivityLog>(entity =>
            {
                entity.ToTable("EntityActivityLog");

                entity.Property(e => e.Action)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.LookUp)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EscortOrderMaster>(entity =>
            {
                entity.ToTable("EscortOrderMaster");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EndWindow).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.StartWindow).HasColumnType("datetime");

                entity.HasOne(d => d.DropOffPointNavigation)
                    .WithMany(p => p.EscortOrderMasterDropOffPointNavigations)
                    .HasForeignKey(d => d.DropOffPoint)
                    .HasConstraintName("FK_EscortOrderMaster_Branch1");

                entity.HasOne(d => d.PickUp)
                    .WithMany(p => p.EscortOrderMasterPickUps)
                    .HasForeignKey(d => d.PickUpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EscortOrderMaster_Branch");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.EscortOrderMasters)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_EscortOrderMaster_MasterReferenceData");
            });

            modelBuilder.Entity<ExcelColumnMapper>(entity =>
            {
                entity.ToTable("ExcelColumnMapper");

                entity.Property(e => e.MapAttribute)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Mapper)
                    .WithMany(p => p.ExcelColumnMappers)
                    .HasForeignKey(d => d.MapperId)
                    .HasConstraintName("FK_ExcelColumnMapper_Header");
            });

            modelBuilder.Entity<ExcelMapper>(entity =>
            {
                entity.ToTable("ExcelMapper");
            });

            modelBuilder.Entity<FloatDeliveryReScheduleRequest>(entity =>
            {
                entity.ToTable("FloatDeliveryReScheduleRequest");

                entity.Property(e => e.CustomerSign).HasColumnType("image");

                entity.Property(e => e.ReScheduleDt).HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedOn).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FloatDeliverySetting>(entity =>
            {
                entity.Property(e => e.CiscoCpcinvolved).HasColumnName("CiscoCPCInvolved");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MaxAdvanceOrderDays).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.BranchConfiguration)
                    .WithMany(p => p.FloatDeliverySettings)
                    .HasForeignKey(d => d.BranchConfigurationId)
                    .HasConstraintName("FK_BranchConfigurationSettings_BranchConfiguration");

                entity.HasOne(d => d.DefaultTemplate)
                    .WithMany(p => p.FloatDeliverySettings)
                    .HasForeignKey(d => d.DefaultTemplateId)
                    .HasConstraintName("FK_FloatDeliverySettings_Template");

                entity.HasOne(d => d.FloatSource)
                    .WithMany(p => p.FloatDeliverySettings)
                    .HasForeignKey(d => d.FloatSourceId)
                    .HasConstraintName("FK_FloatDeliverySettings_MasterReferenceData");
            });

            modelBuilder.Entity<HandoverBranchMapping>(entity =>
            {
                entity.ToTable("HandoverBranchMapping");

                entity.Property(e => e.ApprovalOwnerRoleId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TransportOwnerRoleId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HandoverMapping>(entity =>
            {
                entity.ToTable("HandoverMapping");

                entity.Property(e => e.PackSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ApprovalOwnerRole)
                    .WithMany(p => p.HandoverMappingApprovalOwnerRoles)
                    .HasForeignKey(d => d.ApprovalOwnerRoleId)
                    .HasConstraintName("FK_HandoverMapping_ApprovalOwnerRoleId");

                entity.HasOne(d => d.DestinationRoleNavigation)
                    .WithMany(p => p.HandoverMappingDestinationRoleNavigations)
                    .HasForeignKey(d => d.DestinationRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HandoverMapping_Destination");

                entity.HasOne(d => d.SourceRoleNavigation)
                    .WithMany(p => p.HandoverMappingSourceRoleNavigations)
                    .HasForeignKey(d => d.SourceRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HandoverMapping_Source");
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HolidayDt).HasColumnType("datetime");

                entity.Property(e => e.HolidayReferenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<IncidentRemark>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Tdid).HasColumnName("TDId");

                entity.HasOne(d => d.Td)
                    .WithMany()
                    .HasForeignKey(d => d.Tdid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncidentRemarks_TDId");
            });

            modelBuilder.Entity<IncidentRemarksArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("IncidentRemarks_Archived_10Feb2021");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Tdid).HasColumnName("TDId");
            });

            modelBuilder.Entity<InfoComponent>(entity =>
            {
                entity.Property(e => e.AccessCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceQuery).IsUnicode(false);
            });

            modelBuilder.Entity<InternalHandoverLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InternalHandoverLog");

                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ActionDateTime).HasColumnType("datetime");

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CageID");

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryAccount>(entity =>
            {
                entity.ToTable("InventoryAccount");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerIds).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<InventoryAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InventoryAudit");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NewAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NewCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewItemType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.OriginalCurrency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OriginalItemType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<KycAnswer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KYC_Answers");

                entity.Property(e => e.Answer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<KycCategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KYC_Category");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("category");
            });

            modelBuilder.Entity<KycOption>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KYC_Options");

                entity.Property(e => e.Options)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KycQuestion>(entity =>
            {
                entity.ToTable("KYC_Questions");

                entity.Property(e => e.CssClass)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DataSourceJson).IsUnicode(false);

                entity.Property(e => e.DataUrl)
                    .IsUnicode(false)
                    .HasColumnName("DataURL");

                entity.Property(e => e.InputType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ParentArgument)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Questions)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerArgument).IsUnicode(false);

                entity.Property(e => e.ValidationMessage).IsUnicode(false);
            });

            modelBuilder.Entity<KycQuestionAttribute>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("KYC_QuestionAttributes");

                entity.Property(e => e.AnswerType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attributeId");

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("attributeName");

                entity.Property(e => e.CssClass)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsMandotory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasdepositOrder>(entity =>
            {
                entity.ToTable("MASDepositOrder");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MasdepositOrderCategories)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MasdepositOrders)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.MasdepositOrderCurrencyTypes)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASDepositOrder_MasterReferenceData_CurrenctTypeId");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MasdepositOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.MasdepositOrderSeries)
                    .HasForeignKey(d => d.SeriesId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MasdepositOrderDetail>(entity =>
            {
                entity.ToTable("MASDepositOrderDetails");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MasdepositOrderMasterId).HasColumnName("MASDepositOrderMasterId");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MasdepositOrderDetailCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__MASDeposi__Categ__0140AAD8");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.MasdepositOrderDetails)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASDeposi__Curre__004C869F");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.MasdepositOrderDetailCurrencyTypes)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .HasConstraintName("FK__MASDeposi__Curre__7F586266");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.MasdepositOrderDetailForms)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK__MASDeposi__FormI__0234CF11");

                entity.HasOne(d => d.MasdepositOrderMaster)
                    .WithMany(p => p.MasdepositOrderDetails)
                    .HasForeignKey(d => d.MasdepositOrderMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASDeposi__MASDe__7E643E2D");

                entity.HasOne(d => d.ParentCategory)
                    .WithMany(p => p.MasdepositOrderDetailParentCategories)
                    .HasForeignKey(d => d.ParentCategoryId)
                    .HasConstraintName("FK__MASDeposi__Paren__0328F34A");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.MasdepositOrderDetailSeries)
                    .HasForeignKey(d => d.SeriesId)
                    .HasConstraintName("FK__MASDeposi__Serie__041D1783");
            });

            modelBuilder.Entity<MasdepositOrderMaster>(entity =>
            {
                entity.ToTable("MASDepositOrderMaster");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.MasdepositOrderMasters)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASDeposi__Custo__7C7BF5BB");
            });

            modelBuilder.Entity<MasenvelopsHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MASEnvelopsHistory");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EnvelopNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OldEnvelopNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<MasformMaster>(entity =>
            {
                entity.ToTable("MASFormMaster");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MasformsSetting>(entity =>
            {
                entity.ToTable("MASFormsSetting");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MasformsSettingCategories)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_MASFormsSetting_MasterReferenceData3");

                entity.HasOne(d => d.CurrencyType)
                    .WithMany(p => p.MasformsSettingCurrencyTypes)
                    .HasForeignKey(d => d.CurrencyTypeId)
                    .HasConstraintName("FK_MASFormsSetting_MasterReferenceData1");

                entity.HasOne(d => d.Form)
                    .WithMany(p => p.MasformsSettingForms)
                    .HasForeignKey(d => d.FormId)
                    .HasConstraintName("FK_MASFormsSetting_MasterReferenceData");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MasformsSettings)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_MASFormsSetting_Product");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.MasformsSettingSeries)
                    .HasForeignKey(d => d.SeriesId)
                    .HasConstraintName("FK_MASFormsSetting_MasterReferenceData2");
            });

            modelBuilder.Entity<MashandoverMapping>(entity =>
            {
                entity.ToTable("MASHandoverMapping");

                entity.Property(e => e.PackSource)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ApprovalOwnerRole)
                    .WithMany(p => p.MashandoverMappingApprovalOwnerRoles)
                    .HasForeignKey(d => d.ApprovalOwnerRoleId)
                    .HasConstraintName("FK_MASHandoverMapping_ApprovalOwnerRoleId");

                entity.HasOne(d => d.DestinationRoleNavigation)
                    .WithMany(p => p.MashandoverMappingDestinationRoleNavigations)
                    .HasForeignKey(d => d.DestinationRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASHandoverMapping_Destination");

                entity.HasOne(d => d.SourceRoleNavigation)
                    .WithMany(p => p.MashandoverMappingSourceRoleNavigations)
                    .HasForeignKey(d => d.SourceRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASHandoverMapping_Source");
            });

            modelBuilder.Entity<MasorderApprovalRequest>(entity =>
            {
                entity.ToTable("MASOrderApprovalRequest");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Response)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pack)
                    .WithMany(p => p.MasorderApprovalRequests)
                    .HasForeignKey(d => d.PackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASOrderApprovalRequest_PackId");

                entity.HasOne(d => d.RespondedBy)
                    .WithMany(p => p.MasorderApprovalRequests)
                    .HasForeignKey(d => d.RespondedById)
                    .HasConstraintName("FK_MASOrderApprovalRequest_User");
            });

            modelBuilder.Entity<MasorderHistory>(entity =>
            {
                entity.ToTable("MASOrderHistory");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MasorderId).HasColumnName("MASOrderId");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MasorderHistories)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_MASOrderHistory_StatusId");
            });

            modelBuilder.Entity<MaspackMovementApprovalRequest>(entity =>
            {
                entity.ToTable("MASPackMovementApprovalRequest");

                entity.Property(e => e.MaspackingListId).HasColumnName("MASPackingListId");

                entity.Property(e => e.RequestedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaspackingList>(entity =>
            {
                entity.ToTable("MASPackingList");

                entity.Property(e => e.BagNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MasdetailsId).HasColumnName("MASDetailsId");

                entity.Property(e => e.SealType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.DestinationOwnerNavigation)
                    .WithMany(p => p.MaspackingLists)
                    .HasForeignKey(d => d.DestinationOwner)
                    .HasConstraintName("FK__MASPackin__Desti__46136164");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.MaspackingListStatusNavigations)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK_MASPackingList_Status");

                entity.HasOne(d => d.TeamNavigation)
                    .WithMany(p => p.MaspackingListTeamNavigations)
                    .HasForeignKey(d => d.Team)
                    .HasConstraintName("FK_MASPackingList_Team");
            });

            modelBuilder.Entity<MasterReferenceDatum>(entity =>
            {
                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DataAbbr)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MasterReferenceData)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<MastransportMaster>(entity =>
            {
                entity.ToTable("MASTransportMaster");

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MasorderId).HasColumnName("MASOrderId");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.DropOffPointNavigation)
                    .WithMany(p => p.MastransportMasters)
                    .HasForeignKey(d => d.DropOffPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MASTransp__DropO__15C52FC4");

                entity.HasOne(d => d.Masorder)
                    .WithMany(p => p.MastransportMasters)
                    .HasForeignKey(d => d.MasorderId)
                    .HasConstraintName("FK__MASTransp__MASOr__4AD81681");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.MastransportMasters)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__MASTransp__Statu__4BCC3ABA");
            });

            modelBuilder.Entity<Mb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MB");

                entity.Property(e => e.ActualFromTime)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ActualToTime)
                    .HasMaxLength(19)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Address1)
                    .HasMaxLength(767)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DownloadDt)
                    .HasMaxLength(122)
                    .IsUnicode(false);

                entity.Property(e => e.DropOffPointCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FunctionalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OperationDate)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OpertaionEndWindow)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OpertaionStartWindow)
                    .HasMaxLength(17)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpPointCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ReAssignHstry)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaffCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName)
                    .IsRequired()
                    .HasMaxLength(511)
                    .IsUnicode(false);

                entity.Property(e => e.TeamCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MenuNavigation>(entity =>
            {
                entity.ToTable("MenuNavigation");

                entity.Property(e => e.Application)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Iconpath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId);
            });

            modelBuilder.Entity<MobileJobMessage>(entity =>
            {
                entity.ToTable("MobileJobMessage");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.MessagePriority).HasMaxLength(20);

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TextMessage)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<NccBank>(entity =>
            {
                entity.ToTable("NCC_Banks");

                entity.Property(e => e.AcnoMaxDigit).HasColumnName("ACNoMaxDigit");

                entity.Property(e => e.AcnoMinDigit).HasColumnName("ACNoMinDigit");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<Ncctemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NCCTemplate");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcctemplateDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NCCTemplateDetail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<NcrCancellationRequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NCR_CancellationRequest");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CancellationReason).HasMaxLength(255);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RequestedDt).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<NcrContactUsEnquiry>(entity =>
            {
                entity.ToTable("NCR_ContactUsEnquiry");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDt).HasColumnType("datetime");

                entity.Property(e => e.EmailId).HasMaxLength(255);

                entity.Property(e => e.EnquiryMessage).HasMaxLength(500);

                entity.Property(e => e.EnquiryType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Newsfeed>(entity =>
            {
                entity.ToTable("Newsfeed");

                entity.Property(e => e.Module)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Notification)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("RedirectURL");

                entity.Property(e => e.SentOn)
                    .HasColumnType("datetime")
                    .HasColumnName("sentOn");
            });

            modelBuilder.Entity<NotificationGroup>(entity =>
            {
                entity.ToTable("NotificationGroup");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificationRecipient>(entity =>
            {
                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Recipient)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotifyByPermission>(entity =>
            {
                entity.ToTable("NotifyByPermission");

                entity.Property(e => e.EventType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageTemplate).IsUnicode(false);

                entity.Property(e => e.ReDirectTo).IsUnicode(false);

                entity.Property(e => e.RoleId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderApprovalRequest>(entity =>
            {
                entity.ToTable("OrderApprovalRequest");

                entity.HasIndex(e => e.OrderId, "OrderApproval_Index");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Response)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ApprovalOwner)
                    .WithMany(p => p.OrderApprovalRequestApprovalOwners)
                    .HasForeignKey(d => d.ApprovalOwnerId);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderApprovalRequests)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RespondedBy)
                    .WithMany(p => p.OrderApprovalRequestRespondedBies)
                    .HasForeignKey(d => d.RespondedById);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.OrderApprovalRequests)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<OrderApprovalRule>(entity =>
            {
                entity.ToTable("OrderApprovalRule");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.RuleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderApprovalRuleDetail>(entity =>
            {
                entity.ToTable("OrderApprovalRuleDetail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.ToTable("OrderDetail");

                entity.HasIndex(e => new { e.OrderId, e.Amount }, "OrderDetail_Index");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderDetailFromMa>(entity =>
            {
                entity.ToTable("OrderDetail_FromMAS");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderDetailFromMas)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderDetailFromMas)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderGroup>(entity =>
            {
                entity.ToTable("OrderGroup");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderGroups)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<OrderMaster>(entity =>
            {
                entity.ToTable("OrderMaster");

                entity.HasIndex(e => e.CollectionRefId, "Index_IsVaultDelivery");

                entity.HasIndex(e => new { e.IsDeleted, e.ExpectedDeliveryDt }, "OrderMaster");

                entity.HasIndex(e => e.ExpectedDeliveryDt, "OrderProcessIndex");

                entity.Property(e => e.BillingNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DeliveryContactName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryContactNumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ExpectedDeliveryDt).HasColumnType("datetime");

                entity.Property(e => e.ExpectedTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.ExpectedTimeTo).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderSource)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PickupTimeFrom).HasColumnType("datetime");

                entity.Property(e => e.PickupTimeTo).HasColumnType("datetime");

                entity.Property(e => e.ReScheduledDt).HasColumnType("date");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CollectionRef)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.CollectionRefId)
                    .HasConstraintName("FK_OrderMaster_CollectionRefId");

                entity.HasOne(d => d.Configuration)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.ConfigurationId)
                    .HasConstraintName("FK_OrderMaster_ConfigurationId");

                entity.HasOne(d => d.Contract)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.ContractId);

                entity.HasOne(d => d.OrderGroup)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.OrderGroupId);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.OrderMasters)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("OrderMaster_TemplateId_FK");
            });

            modelBuilder.Entity<OrderStorage>(entity =>
            {
                entity.ToTable("OrderStorage");

                entity.Property(e => e.ConsumedSpace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StorageDate).HasColumnType("date");

                entity.HasOne(d => d.CustomerOrderSummary)
                    .WithMany(p => p.OrderStorages)
                    .HasForeignKey(d => d.CustomerOrderSummaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderStorage_OrderStorage");

                entity.HasOne(d => d.Slot)
                    .WithMany(p => p.OrderStorages)
                    .HasForeignKey(d => d.SlotId)
                    .HasConstraintName("FK_OrderStorage_Slot");
            });

            modelBuilder.Entity<OrderTeamAllocation>(entity =>
            {
                entity.ToTable("OrderTeamAllocation");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderTeamAllocations)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderTeamAllocation_OrderMaster");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.OrderTeamAllocations)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderTeamAllocation_MasterReferenceData");
            });

            modelBuilder.Entity<OrderWorkflowFormValue>(entity =>
            {
                entity.ToTable("OrderWorkflowFormValue");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Value).HasMaxLength(255);
            });

            modelBuilder.Entity<OrderWorkflowHistory>(entity =>
            {
                entity.ToTable("OrderWorkflowHistory");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderWorkflowHistories)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderWorkFlowHistory_OrderId");
            });

            modelBuilder.Entity<PackMovementApprovalRequest>(entity =>
            {
                entity.ToTable("PackMovementApprovalRequest");

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestedDt).HasColumnType("datetime");

                entity.Property(e => e.RespondedDt).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TakenOverDt).HasColumnType("datetime");

                entity.HasOne(d => d.PackTrack)
                    .WithMany(p => p.PackMovementApprovalRequests)
                    .HasForeignKey(d => d.PackTrackId)
                    .HasConstraintName("FK_PackMovementApprovalRequest_PackTrackId");

                entity.HasOne(d => d.RejectOwnerNavigation)
                    .WithMany(p => p.PackMovementApprovalRequestRejectOwnerNavigations)
                    .HasForeignKey(d => d.RejectOwner)
                    .HasConstraintName("FK_PackMovementApprovalRequest_RejectOwner");

                entity.HasOne(d => d.RequestOwnerNavigation)
                    .WithMany(p => p.PackMovementApprovalRequestRequestOwnerNavigations)
                    .HasForeignKey(d => d.RequestOwner)
                    .HasConstraintName("FK_PackMovementApprovalRequest_RequestOwner");
            });

            modelBuilder.Entity<PackMovementApprovalRequestArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PackMovementApprovalRequest_Archived_10Feb2021");

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequestedDt).HasColumnType("datetime");

                entity.Property(e => e.RespondedDt).HasColumnType("datetime");

                entity.Property(e => e.Response)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.SecurityStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TakenOverDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<PackTrack>(entity =>
            {
                entity.ToTable("PackTrack");

                entity.HasIndex(e => e.CollectionPackId, "Idx_Packtrack");

                entity.HasIndex(e => new { e.CurrentOwner, e.Status }, "PackTrack_Index");

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cashier)
                    .WithMany(p => p.PackTracks)
                    .HasForeignKey(d => d.CashierId)
                    .HasConstraintName("FK_PackTrack_CashierId");

                entity.HasOne(d => d.CollectionPack)
                    .WithMany(p => p.PackTracks)
                    .HasForeignKey(d => d.CollectionPackId)
                    .HasConstraintName("FK_PackTrack_CollectionId");
            });

            modelBuilder.Entity<PackTrackArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PackTrack_Archived_10Feb2021");

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackTrackHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PackTrackHistory");

                entity.Property(e => e.ActionHistory).IsUnicode(false);

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.GroupNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PackingList>(entity =>
            {
                entity.ToTable("PackingList");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.EnvelopNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.PackingLists)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Packinglist_OrderId");
            });

            modelBuilder.Entity<PacktrackHistory1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PacktrackHistory1");

                entity.HasIndex(e => new { e.CollectionPackId, e.HistoryDt, e.Status }, "idx_PacktrackHisotry");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CageId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionPackId).HasColumnName("collectionPackId");

                entity.Property(e => e.CurrentOwner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Deno).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DestinationOwner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HistoryDt).HasColumnType("datetime");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedUser)
                    .HasMaxLength(564)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.ToTable("Permission");

                entity.Property(e => e.AccessCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.PermissionCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FK_Permission_Module_ModuleId");
            });

            modelBuilder.Entity<PermissionAction>(entity =>
            {
                entity.ToTable("PermissionAction");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.PermissionActions)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PermissionAction_Permission_ActionId");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionActions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PermissionRole>(entity =>
            {
                entity.ToTable("PermissionRole");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.PermissionRoles)
                    .HasForeignKey(d => d.ActionId)
                    .HasConstraintName("FK_PermissionRole_Action_ActionId");

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.PermissionRoles)
                    .HasForeignKey(d => d.PermissionId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PermissionRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PostalCodeMaster>(entity =>
            {
                entity.ToTable("PostalCodeMaster");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.ExcessRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrePackedBkp17032020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrePackedBKP_17032020");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrintReceiptSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PrintReceiptSetting");

                entity.Property(e => e.FooterText).IsRequired();

                entity.Property(e => e.HeaderText).IsRequired();

                entity.Property(e => e.Logo).IsRequired();
            });

            modelBuilder.Entity<ProcessingTransportId>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");

                entity.Property(e => e.AttributeCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AttributeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.ToTable("ProductAttributeValue");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Value)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ProductAttributeValues)
                    .HasForeignKey(d => d.AttributeId);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductAttributeValues)
                    .HasForeignKey(d => d.ProductId);
            });

            modelBuilder.Entity<QueryBuilderMap>(entity =>
            {
                entity.ToTable("QueryBuilderMap");

                entity.Property(e => e.Alias)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SchemaName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferenceDataCategory>(entity =>
            {
                entity.ToTable("ReferenceDataCategory");

                entity.Property(e => e.CategoryCd)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryDesc)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryOwner)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Registration>(entity =>
            {
                entity.ToTable("Registration");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ArcaNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ARCA_NO");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.NricFin)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("NRIC_FIN");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegisteredOn).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_Address");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Registration_Registration");

                entity.HasOne(d => d.SubscriptionTypeNavigation)
                    .WithMany(p => p.Registrations)
                    .HasForeignKey(d => d.SubscriptionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Registration_MasterReferenceData");
            });

            modelBuilder.Entity<RegistrationHistory>(entity =>
            {
                entity.ToTable("RegistrationHistory");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GateWayProcessingCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gstamount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GSTAmount");

                entity.Property(e => e.GwHmac)
                    .HasMaxLength(100)
                    .HasColumnName("GW_HMAC");

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.NetsTxnRef)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("netsTxnRef");

                entity.Property(e => e.NetstxnRand)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("netstxnRand");

                entity.Property(e => e.PaymentDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SubscriptionAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SubscriptionRefNumber).HasMaxLength(50);

                entity.Property(e => e.TotalSubscriptionAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.ApprovedSubscriptionType)
                    .WithMany(p => p.RegistrationHistoryApprovedSubscriptionTypes)
                    .HasForeignKey(d => d.ApprovedSubscriptionTypeId)
                    .HasConstraintName("FK_RegistrationHistory_MasterReferenceData1");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.RegistrationHistories)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_RegistrationHistory_Bank");

                entity.HasOne(d => d.Registration)
                    .WithMany(p => p.RegistrationHistories)
                    .HasForeignKey(d => d.RegistrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationHistory_Registration");

                entity.HasOne(d => d.ReqSubscriptionType)
                    .WithMany(p => p.RegistrationHistoryReqSubscriptionTypes)
                    .HasForeignKey(d => d.ReqSubscriptionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationHistory_MasterReferenceData");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoutingDropOffWindow>(entity =>
            {
                entity.ToTable("RoutingDropOffWindow");

                entity.Property(e => e.FriEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fri_EndWindow");

                entity.Property(e => e.FriStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Fri_StartWindow");

                entity.Property(e => e.MonEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mon_EndWindow");

                entity.Property(e => e.MonStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mon_StartWindow");

                entity.Property(e => e.SatEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sat_EndWindow");

                entity.Property(e => e.SatStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sat_StartWindow");

                entity.Property(e => e.SunEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sun_EndWindow");

                entity.Property(e => e.SunStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Sun_StartWindow");

                entity.Property(e => e.ThuEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Thu_EndWindow");

                entity.Property(e => e.ThuStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Thu_StartWindow");

                entity.Property(e => e.TueEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tue_EndWindow");

                entity.Property(e => e.TueStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tue_StartWindow");

                entity.Property(e => e.UpdatedBy).HasColumnName("updatedBy");

                entity.Property(e => e.UpdatedDt).HasColumnType("datetime");

                entity.Property(e => e.WedEndWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Wed_EndWindow");

                entity.Property(e => e.WedStartWindow)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Wed_StartWindow");
            });

            modelBuilder.Entity<S2sresponce>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("S2SResponce");

                entity.Property(e => e.Message).HasColumnName("message");
            });

            modelBuilder.Entity<SavedQuery>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.QueryName)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScheduleDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ScheduleDetail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Rule)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.ScheduleMaster)
                    .WithMany()
                    .HasForeignKey(d => d.ScheduleMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleDetails_ScheduleMaster_Id");
            });

            modelBuilder.Entity<ScheduleMaster>(entity =>
            {
                entity.ToTable("ScheduleMaster");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.IntervalType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ScheduledDate>(entity =>
            {
                entity.ToTable("ScheduledDate");

                entity.HasIndex(e => new { e.BranchId, e.BranchScheduleId, e.Day, e.IsDeleted, e.ScheduleDt }, "ScheduledDate_Index_1");

                entity.HasIndex(e => e.ScheduleDt, "ScheduledDate_Index_2");

                entity.Property(e => e.BillingNo).HasMaxLength(50);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ScheduleDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.ScheduledDates)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BranchSchedule)
                    .WithMany(p => p.ScheduledDates)
                    .HasForeignKey(d => d.BranchScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SecurityDeposit>(entity =>
            {
                entity.ToTable("SecurityDeposit");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DepositAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SecurityDeposits)
                    .HasForeignKey(d => d.CustomerId);
            });

            modelBuilder.Entity<Slot>(entity =>
            {
                entity.ToTable("Slot");

                entity.Property(e => e.BlockReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.BlockedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DynamicCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StorageSize).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.SlotScheduleDetail)
                    .WithMany(p => p.Slots)
                    .HasForeignKey(d => d.SlotScheduleDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotScheduleOrderDetail_SlotScheduleDetail");
            });

            modelBuilder.Entity<SlotCustomer>(entity =>
            {
                entity.ToTable("SlotCustomer");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SlotCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotCustomer_Customer");

                entity.HasOne(d => d.SlotSchedule)
                    .WithMany(p => p.SlotCustomers)
                    .HasForeignKey(d => d.SlotScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotCustomer_SlotSchedule");
            });

            modelBuilder.Entity<SlotPricing>(entity =>
            {
                entity.ToTable("SlotPricing");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CutoffHours).HasDefaultValueSql("((0))");

                entity.Property(e => e.CutoffInterval).HasDefaultValueSql("((0))");

                entity.Property(e => e.DynamicCalcType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);

                entity.Property(e => e.DynamicIncrement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.MaximumPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SlotType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.CitType)
                    .WithMany(p => p.SlotPricings)
                    .HasForeignKey(d => d.CitTypeId)
                    .HasConstraintName("FK_SlotPricing_MasterReferenceData");
            });

            modelBuilder.Entity<SlotSchedule>(entity =>
            {
                entity.ToTable("SlotSchedule");

                entity.Property(e => e.AllocatedStorage).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.SlotType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.HasOne(d => d.ScheduleMaster)
                    .WithMany(p => p.SlotSchedules)
                    .HasForeignKey(d => d.ScheduleMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotSchedule_ScheduleMaster");
            });

            modelBuilder.Entity<SlotScheduleDetail>(entity =>
            {
                entity.ToTable("SlotScheduleDetail");

                entity.Property(e => e.AllocatedStorage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cittypeid).HasColumnName("CITTypeid");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.DynamicIncrement).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.NumberOfJobs).HasDefaultValueSql("((1))");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScheduledDate).HasColumnType("date");

                entity.HasOne(d => d.Cittype)
                    .WithMany(p => p.SlotScheduleDetails)
                    .HasForeignKey(d => d.Cittypeid)
                    .HasConstraintName("FK_SlotScheduleDetail_MasterReferenceData");

                entity.HasOne(d => d.SlotPrice)
                    .WithMany(p => p.SlotScheduleDetails)
                    .HasForeignKey(d => d.SlotPriceId)
                    .HasConstraintName("FK_SlotScheduleDetail_SlotPricing");

                entity.HasOne(d => d.SlotSchedule)
                    .WithMany(p => p.SlotScheduleDetails)
                    .HasForeignKey(d => d.SlotScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SlotScheduleDetail_SlotSchedule");
            });

            modelBuilder.Entity<SlotType>(entity =>
            {
                entity.ToTable("SlotType");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cittype).HasColumnName("CITType");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.SlotType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SlotType");

                entity.HasOne(d => d.CittypeNavigation)
                    .WithMany(p => p.SlotTypes)
                    .HasForeignKey(d => d.Cittype)
                    .HasConstraintName("FK_SlotType_MasterReferenceData");
            });

            modelBuilder.Entity<Stuteam>(entity =>
            {
                entity.ToTable("STUTeam");

                entity.Property(e => e.AssignDt).HasColumnType("datetime");

                entity.Property(e => e.Break1EndTime).HasColumnType("datetime");

                entity.Property(e => e.Break1StartTime).HasColumnType("datetime");

                entity.Property(e => e.Break2EndTime).HasColumnType("datetime");

                entity.Property(e => e.Break2StartTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.VehicleStartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Stuteams)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__STUTeam__TeamId__0ABD916C");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Stuteams)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__STUTeam__UserId__0BB1B5A5");
            });

            modelBuilder.Entity<SubscriptionServiceConfig>(entity =>
            {
                entity.ToTable("SubscriptionServiceConfig");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.ServiceType)
                    .WithMany(p => p.SubscriptionServiceConfigServiceTypes)
                    .HasForeignKey(d => d.ServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionServiceConfig_MasterReferenceData1");

                entity.HasOne(d => d.SubscriptionType)
                    .WithMany(p => p.SubscriptionServiceConfigSubscriptionTypes)
                    .HasForeignKey(d => d.SubscriptionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubscriptionServiceConfig_MasterReferenceData");
            });

            modelBuilder.Entity<SystemActivityLog>(entity =>
            {
                entity.ToTable("SystemActivityLog");

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Entity)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemConfig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SystemConfig");

                entity.HasIndex(e => e.AccessKey, "SystemConfig_AccessKey")
                    .IsUnique();

                entity.Property(e => e.AccessKey)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Value)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemModule>(entity =>
            {
                entity.ToTable("SystemModule");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TeamBreakLog>(entity =>
            {
                entity.ToTable("TeamBreakLog");

                entity.Property(e => e.ApprovedDt).HasColumnType("datetime");

                entity.Property(e => e.BreakDt).HasColumnType("date");

                entity.Property(e => e.CancelledOn).HasColumnType("datetime");

                entity.Property(e => e.CancelledRemarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FromTime)
                    .HasColumnType("datetime")
                    .HasColumnName("FromTIme");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedOn).HasColumnType("datetime");

                entity.Property(e => e.ToTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.ToTable("Template");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateBranch>(entity =>
            {
                entity.ToTable("TemplateBranch");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.TemplateBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.TemplateBranches)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TemplateDetail>(entity =>
            {
                entity.ToTable("TemplateDetail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.CustomerProduct)
                    .WithMany(p => p.TemplateDetails)
                    .HasForeignKey(d => d.CustomerProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateDetail_CustomerProduct_CustomerProductId1");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.TemplateDetails)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TmpTimeUpdate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tmpTimeUpdate");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryEta)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryETA");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpEta)
                    .HasColumnType("datetime")
                    .HasColumnName("PickUpETA");

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportDetail>(entity =>
            {
                entity.HasIndex(e => e.TransportId, "Idx_TransportDetails");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssignedToTeam).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(case when [SealNo] IS NULL then CONVERT([varchar](50),[Id]) else [SealNo] end)", false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.IsSafeKeepItem).HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReadyToDeliver).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcsscannedBy).HasColumnName("VCSScannedBy");

                entity.Property(e => e.VcsscannedTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("VCSScannedTimeStamp");

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.TransportDetails)
                    .HasForeignKey(d => d.TransportId)
                    .HasConstraintName("FK__Transport__Trans__4E952F7A");
            });

            modelBuilder.Entity<TransportDetails12022020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportDetails_12_02_2020");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportDetails22012020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportDetails_22_01_2020");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportDetailsArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportDetails_Archived_10Feb2021");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcsscannedBy).HasColumnName("VCSScannedBy");

                entity.Property(e => e.VcsscannedTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("VCSScannedTimeStamp");
            });

            modelBuilder.Entity<TransportDetailsBk12112020>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportDetails_bk_12112020");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComputedColumn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ScannedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SealNo2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VcsscannedBy).HasColumnName("VCSScannedBy");

                entity.Property(e => e.VcsscannedTimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("VCSScannedTimeStamp");
            });

            modelBuilder.Entity<TransportEnvelop>(entity =>
            {
                entity.ToTable("TransportEnvelop");

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Detail)
                    .WithMany(p => p.TransportEnvelops)
                    .HasForeignKey(d => d.DetailId)
                    .HasConstraintName("FK_TransportEnvelop_DetailId");
            });

            modelBuilder.Entity<TransportEnvelopArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportEnvelop_Archived_10Feb2021");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SealNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportMaster>(entity =>
            {
                entity.ToTable("TransportMaster");

                entity.HasIndex(e => e.CollectionOrderId, "INDX_TransportMaster_CollectionOrderId");

                entity.HasIndex(e => e.FloatDeliveryOrderId, "INDX_TransportMaster_FloatDeliveryOrderId");

                entity.HasIndex(e => new { e.OrderDt, e.CollectionOrderId }, "Index_OrderDateCollectionId");

                entity.HasIndex(e => new { e.IsDeleted, e.OrderDt }, "TransportMaster_Index");

                entity.HasIndex(e => e.OrderNo, "UC_OrderNo")
                    .IsUnique();

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CName");

                entity.Property(e => e.CollectionMode).IsUnicode(false);

                entity.Property(e => e.ConsumableRemarks).IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryEta)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryETA");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForcedSequence).IsUnicode(false);

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.KeyFromKms).IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpEta)
                    .HasColumnType("datetime")
                    .HasColumnName("PickUpETA");

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("StaffID");

                entity.Property(e => e.TakeOverDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaskingOrderInstruction).IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CollectionOrder)
                    .WithMany(p => p.TransportMasters)
                    .HasForeignKey(d => d.CollectionOrderId)
                    .HasConstraintName("FK_CollectionOrderId");

                entity.HasOne(d => d.DropOffPointNavigation)
                    .WithMany(p => p.TransportMasterDropOffPointNavigations)
                    .HasForeignKey(d => d.DropOffPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transport__DropO__45FFE979");

                entity.HasOne(d => d.FloatDeliveryOrder)
                    .WithMany(p => p.TransportMasters)
                    .HasForeignKey(d => d.FloatDeliveryOrderId)
                    .HasConstraintName("FK_FloatDeliveryOrderId");

                entity.HasOne(d => d.PickUpPointNavigation)
                    .WithMany(p => p.TransportMasterPickUpPointNavigations)
                    .HasForeignKey(d => d.PickUpPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Transport__PickU__450BC540");

                entity.HasOne(d => d.StatusNavigation)
                    .WithMany(p => p.TransportMasterStatusNavigations)
                    .HasForeignKey(d => d.Status)
                    .HasConstraintName("FK__Transport__Statu__666CB90B");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TransportMasterTeams)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK__Transport__TeamI__46F40DB2");
            });

            modelBuilder.Entity<TransportMasterArchived10feb2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportMaster_Archived_10Feb2021");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Cname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CName");

                entity.Property(e => e.CollectionMode).IsUnicode(false);

                entity.Property(e => e.ConsumableRemarks).IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryEta)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryETA");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForcedSequence).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.KeyFromKms).IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpEta)
                    .HasColumnType("datetime")
                    .HasColumnName("PickUpETA");

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaffId)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("StaffID");

                entity.Property(e => e.TakeOverDateTime).HasColumnType("datetime");

                entity.Property(e => e.TaskingOrderInstruction).IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportMasterBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportMasterBKP");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryEta)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryETA");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpEta)
                    .HasColumnType("datetime")
                    .HasColumnName("PickUpETA");

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportMasterBkp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportMasterBKP1");

                entity.Property(e => e.AccountManager)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.CustomerSapNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryEta)
                    .HasColumnType("datetime")
                    .HasColumnName("DeliveryETA");

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Instruction).IsUnicode(false);

                entity.Property(e => e.InvoiceRefNo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndTime).HasColumnType("datetime");

                entity.Property(e => e.JobStartTime).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PickUpEta)
                    .HasColumnType("datetime")
                    .HasColumnName("PickUpETA");

                entity.Property(e => e.SapreffNo)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SAPReffNo");

                entity.Property(e => e.SequenceNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportMasterLookUp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransportMasterLookUp");

                entity.Property(e => e.BlockOffTimeEnd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BlockOffTimeStart)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Citdetails)
                    .IsRequired()
                    .HasMaxLength(174)
                    .IsUnicode(false)
                    .HasColumnName("CITDetails");

                entity.Property(e => e.Cittype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITType");

                entity.Property(e => e.CodeForDropOffPoint)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CollectionMode)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(110)
                    .IsUnicode(false);

                entity.Property(e => e.DEta)
                    .HasColumnType("datetime")
                    .HasColumnName("D_ETA");

                entity.Property(e => e.Dpaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DPAddress");

                entity.Property(e => e.DppostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("DPPostCode");

                entity.Property(e => e.DropEndDate).HasColumnType("datetime");

                entity.Property(e => e.DropOffType)
                    .IsRequired()
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.DropStartDate).HasColumnType("datetime");

                entity.Property(e => e.EstimatedCash)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingSequence)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingTeam)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ExistingVehicle)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ForcedSequence)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ItemTobeWithdrawn)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobEndDate).HasColumnType("datetime");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobStartDate).HasColumnType("datetime");

                entity.Property(e => e.JobTag)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.JobType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mde)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("mde");

                entity.Property(e => e.OrderAction)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDt).HasColumnType("datetime");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PEta)
                    .HasColumnType("datetime")
                    .HasColumnName("P_ETA");

                entity.Property(e => e.Pcs)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PCS");

                entity.Property(e => e.Ppaddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("PPAddress");

                entity.Property(e => e.PppostCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("PPPostCode");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RequiredVehicleType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Signature)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VersionNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfileImage).HasMaxLength(1);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TitleId);
            });

            modelBuilder.Entity<UserAction>(entity =>
            {
                entity.ToTable("UserAction");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ActionCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.UserGroup1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("UserGroup");
            });

            modelBuilder.Entity<UserGroupUser>(entity =>
            {
                entity.ToTable("UserGroupUser");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.UserGroupUsers)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserGroupUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserRememberMe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserRememberMe");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SeriesHash).HasMaxLength(100);

                entity.Property(e => e.SeriesToken)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroupRole_Role_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<VaultDeliveryInventoryAssignAudit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VaultDeliveryInventoryAssignAudit");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ItemType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<VaultDeliveryItemDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Deliverables).IsUnicode(false);

                entity.Property(e => e.DeliverablesWithSeries).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VaultDeliveryTransportDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VwApprovalLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ApprovalLog");
            });

            modelBuilder.Entity<VwBranchAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_BranchAddress");

                entity.Property(e => e.BranchCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PinCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StreetName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tower)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCollectionApprovalLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CollectionApprovalLog");
            });

            modelBuilder.Entity<VwContactDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ContactDetails");

                entity.Property(e => e.ContactDetail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ContactType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCurrencyProductAttribute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CurrencyProductAttribute");

                entity.Property(e => e.BoxAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BundleAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BundleCount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsCoin)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RollStackAmount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RollStackCount)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RollStackInBox)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCustomerUserMapping>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CustomerUserMapping");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwCustomerUserMappingOld>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_CustomerUserMapping_Old");

                entity.Property(e => e.FullName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOrderBagPackStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Order_BagPackStatus");

                entity.Property(e => e.Cpcpending).HasColumnName("CPCPending");

                entity.Property(e => e.Cpcreject).HasColumnName("CPCReject");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Stupending).HasColumnName("STUPending");

                entity.Property(e => e.Stureject).HasColumnName("STUReject");
            });

            modelBuilder.Entity<VwOrderWorkFlowStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_OrderWorkFlowStatus");

                entity.Property(e => e.OrderStatus)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPackTrack>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PackTrack");

                entity.Property(e => e.CageNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwPackingList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_PackingList");
            });

            modelBuilder.Entity<VwRoleHeirarchy>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_RoleHeirarchy");

                entity.Property(e => e.Parents).IsUnicode(false);

                entity.Property(e => e.RoleCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwScheduledDeliveryOrderPlaced>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_ScheduledDeliveryOrderPlaced");

                entity.Property(e => e.OrderCuttOffDt).HasColumnType("date");

                entity.Property(e => e.ScheduleDt).HasColumnType("date");
            });

            modelBuilder.Entity<VwStorageStau>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_StorageStaus");

                entity.Property(e => e.Availiable).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.AvailiableWithBlocked).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Blocked).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Booked).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.CanRelease).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.InUse).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ScheduledDate).HasColumnType("date");

                entity.Property(e => e.Total).HasColumnType("decimal(38, 2)");
            });

            modelBuilder.Entity<VwTransportStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Transport_Status");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrderStatus)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.OrderType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwVaultDeliveryOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_VaultDeliveryOrder");
            });

            modelBuilder.Entity<WorkFlowMaster>(entity =>
            {
                entity.ToTable("WorkFlowMaster");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");

                entity.Property(e => e.WorkFlowCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFlowName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkFlowStatus>(entity =>
            {
                entity.ToTable("WorkFlowStatus");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WorkFlowStatusDetail>(entity =>
            {
                entity.ToTable("WorkFlowStatusDetail");

                entity.Property(e => e.CreatedDt).HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDt).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
