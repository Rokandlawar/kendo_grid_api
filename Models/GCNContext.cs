using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace kendo_grid_api.Models
{
    public partial class GCNContext : DbContext
    {
        public GCNContext()
        {
        }

        public GCNContext(DbContextOptions<GCNContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityInvoice> ActivityInvoice { get; set; }
        public virtual DbSet<ActivityInvoice1> ActivityInvoice1 { get; set; }
        public virtual DbSet<ActivityNevents> ActivityNevents { get; set; }
        public virtual DbSet<AggregatedCounter> AggregatedCounter { get; set; }
        public virtual DbSet<ApplicationInvoice> ApplicationInvoice { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<AttachmentTypes> AttachmentTypes { get; set; }
        public virtual DbSet<Attachments> Attachments { get; set; }
        public virtual DbSet<Cameras> Cameras { get; set; }
        public virtual DbSet<ChargeStatement> ChargeStatement { get; set; }
        public virtual DbSet<Charges> Charges { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<CompanyAddress> CompanyAddress { get; set; }
        public virtual DbSet<CompanyInvoices> CompanyInvoices { get; set; }
        public virtual DbSet<CompanySku> CompanySku { get; set; }
        public virtual DbSet<Companymanifest> Companymanifest { get; set; }
        public virtual DbSet<Counter> Counter { get; set; }
        public virtual DbSet<EventInvoice> EventInvoice { get; set; }
        public virtual DbSet<EventInvoice1> EventInvoice1 { get; set; }
        public virtual DbSet<EventStatement> EventStatement { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Files> Files { get; set; }
        public virtual DbSet<Hash> Hash { get; set; }
        public virtual DbSet<Hearbeat> Hearbeat { get; set; }
        public virtual DbSet<Images> Images { get; set; }
        public virtual DbSet<InvoiceCycles> InvoiceCycles { get; set; }
        public virtual DbSet<InvoiceStatement> InvoiceStatement { get; set; }
        public virtual DbSet<InvoiceView> InvoiceView { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<Itemization> Itemization { get; set; }
        public virtual DbSet<ItemizedStatement> ItemizedStatement { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobParameter> JobParameter { get; set; }
        public virtual DbSet<JobQueue> JobQueue { get; set; }
        public virtual DbSet<List> List { get; set; }
        public virtual DbSet<Manifest> Manifest { get; set; }
        public virtual DbSet<ModuleGroups> ModuleGroups { get; set; }
        public virtual DbSet<Notes> Notes { get; set; }
        public virtual DbSet<NoticeTemplates> NoticeTemplates { get; set; }
        public virtual DbSet<Notices> Notices { get; set; }
        public virtual DbSet<NotificationLog> NotificationLog { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<PaymentDetails> PaymentDetails { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<PermitConnections> PermitConnections { get; set; }
        public virtual DbSet<PermitData> PermitData { get; set; }
        public virtual DbSet<PermitGrid> PermitGrid { get; set; }
        public virtual DbSet<Permits> Permits { get; set; }
        public virtual DbSet<PlateResults> PlateResults { get; set; }
        public virtual DbSet<Possibilities> Possibilities { get; set; }
        public virtual DbSet<Receipt> Receipt { get; set; }
        public virtual DbSet<RenewPermits> RenewPermits { get; set; }
        public virtual DbSet<ReportInvoice> ReportInvoice { get; set; }
        public virtual DbSet<RoadNetworks> RoadNetworks { get; set; }
        public virtual DbSet<RoleTypes> RoleTypes { get; set; }
        public virtual DbSet<Schema> Schema { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SkuList> SkuList { get; set; }
        public virtual DbSet<SkuStatement> SkuStatement { get; set; }
        public virtual DbSet<Skus> Skus { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Statement> Statement { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Stories> Stories { get; set; }
        public virtual DbSet<SystemSettings> SystemSettings { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }
        public virtual DbSet<UserLoginHistory> UserLoginHistory { get; set; }
        public virtual DbSet<UserPasswordRecovery> UserPasswordRecovery { get; set; }
        public virtual DbSet<UserPasswords> UserPasswords { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<VehicleStatement> VehicleStatement { get; set; }
        public virtual DbSet<Vehicles> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=34.204.7.249;Initial Catalog=GCN;Persist Security Info=True;User ID=sa;Password=De1@s0fT;MultipleActiveResultSets=True;App=EntityFramework;Min Pool Size=5;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityInvoice");

                entity.Property(e => e.ActivityCode).HasMaxLength(50);

                entity.Property(e => e.FunctionCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode).HasMaxLength(50);
            });

            modelBuilder.Entity<ActivityInvoice1>(entity =>
            {
                entity.ToTable("ActivityInvoice", "Invoice");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActivityNevents>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ActivityNEvents");

                entity.Property(e => e.ActivityCode).HasMaxLength(50);

                entity.Property(e => e.FunctionCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode).HasMaxLength(50);
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("UX_HangFire_CounterAggregated_Key")
                    .IsUnique();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ApplicationInvoice>(entity =>
            {
                entity.ToTable("ApplicationInvoice", "Invoice");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.ToTable("Applications", "Applications");

                entity.Property(e => e.Alexpiration)
                    .HasColumnName("ALExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Glexpiration)
                    .HasColumnName("GLExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wcexpiration)
                    .HasColumnName("WCExpiration")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.ToTable("Articles", "HELP");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttachmentTypes>(entity =>
            {
                entity.ToTable("AttachmentTypes", "ADMIN");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Attachments>(entity =>
            {
                entity.ToTable("Attachments", "Applications");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cameras>(entity =>
            {
                entity.ToTable("Cameras", "ADMIN");

                entity.Property(e => e.CameraId)
                    .HasColumnName("CameraID")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CameraIp)
                    .HasColumnName("CameraIP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CameraUrl)
                    .HasColumnName("CameraURL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChargeStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ChargeStatement");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Charges>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("CHARGES_pk")
                    .IsClustered(false);

                entity.ToTable("CHARGES", "PAYMENT");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company", "Company");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName).HasMaxLength(100);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dotnumber)
                    .HasColumnName("DOTNumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyAddress>(entity =>
            {
                entity.ToTable("CompanyAddress", "Company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyAddress)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyAddress");
            });

            modelBuilder.Entity<CompanyInvoices>(entity =>
            {
                entity.ToTable("CompanyInvoices", "Company");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanySku>(entity =>
            {
                entity.ToTable("CompanySku", "Company");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanySku)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanySku");
            });

            modelBuilder.Entity<Companymanifest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("COMPANYMANIFEST_pk")
                    .IsClustered(false);

                entity.ToTable("COMPANYMANIFEST", "PAYMENT");

                entity.Property(e => e.IsFixed).HasColumnName("isFixed");
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => new { e.Value, e.Key })
                    .HasName("IX_HangFire_Counter_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EventInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EventInvoice");

                entity.Property(e => e.ActivityCode).HasMaxLength(50);

                entity.Property(e => e.ActivityTime).HasColumnName("Activity_Time");

                entity.Property(e => e.FunctionCode).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PlateNumber)
                    .HasColumnName("Plate_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlateRegion)
                    .HasColumnName("Plate_Region")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode).HasMaxLength(50);
            });

            modelBuilder.Entity<EventInvoice1>(entity =>
            {
                entity.ToTable("EventInvoice", "Invoice");
            });

            modelBuilder.Entity<EventStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EventStatement");

                entity.Property(e => e.Activity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTime).HasColumnName("Activity_Time");

                entity.Property(e => e.CameraId)
                    .HasColumnName("Camera_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress1)
                    .HasColumnName("Company_Address_1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("Company_Address_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("Company_DOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ImageId).HasColumnName("Image_Id");

                entity.Property(e => e.ImageUid)
                    .IsRequired()
                    .HasColumnName("Image_Uid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PlateNumber)
                    .IsRequired()
                    .HasColumnName("Plate_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlateRegion)
                    .IsRequired()
                    .HasColumnName("Plate_Region")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.ToTable("Events", "Camera");

                entity.Property(e => e.Activity)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ActivityTime).HasColumnName("Activity_Time");

                entity.Property(e => e.CameraId)
                    .HasColumnName("Camera_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress1)
                    .HasColumnName("Company_Address_1")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyAddress2)
                    .HasColumnName("Company_Address_2")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("Company_DOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.CompanyName)
                    .HasColumnName("Company_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.ImageId).HasColumnName("Image_Id");

                entity.Property(e => e.ImageUid)
                    .IsRequired()
                    .HasColumnName("Image_Uid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.PlateNumber)
                    .IsRequired()
                    .HasColumnName("Plate_Number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PlateRegion)
                    .IsRequired()
                    .HasColumnName("Plate_Region")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Files>(entity =>
            {
                entity.ToTable("Files", "Meta");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extension)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => new { e.ExpireAt, e.Key })
                    .HasName("IX_HangFire_Hash_Key");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Hash_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Field })
                    .HasName("UX_HangFire_Hash_Key_Field")
                    .IsUnique();

                entity.Property(e => e.Field)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Hearbeat>(entity =>
            {
                entity.ToTable("Hearbeat", "Camera");

                entity.Property(e => e.AgentType)
                    .IsRequired()
                    .HasColumnName("Agent_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentUid)
                    .IsRequired()
                    .HasColumnName("Agent_Uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentVersion)
                    .IsRequired()
                    .HasColumnName("Agent_Version")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BeanstalkQueueSize).HasColumnName("Beanstalk_Queue_Size");

                entity.Property(e => e.CameraId)
                    .IsRequired()
                    .HasColumnName("Camera_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpuCores).HasColumnName("Cpu_Cores");

                entity.Property(e => e.CpuLastUpdate)
                    .HasColumnName("Cpu_Last_Update")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.CpuUsagePercent).HasColumnName("Cpu_Usage_Percent");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DaemonUptimeSeconds)
                    .HasColumnName("Daemon_Uptime_Seconds")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnName("Data_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DiskQuotaConsumedBytes).HasColumnName("Disk_Quota_Consumed_Bytes");

                entity.Property(e => e.DiskQuotaLastUpdate).HasColumnName("Disk_Quota_Last_Update");

                entity.Property(e => e.DiskQuotaTotalBytes).HasColumnName("Disk_Quota_Total_Bytes");

                entity.Property(e => e.IsStreaming).HasColumnName("Is_Streaming");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("Last_Update")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.MemoryConsumedBytes).HasColumnName("Memory_Consumed_Bytes");

                entity.Property(e => e.MemoryLastUpdate)
                    .HasColumnName("Memory_Last_Update")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.MemorySwaptotalBytes).HasColumnName("Memory_Swaptotal_Bytes");

                entity.Property(e => e.MemorySwapusedBytes).HasColumnName("Memory_Swapused_Bytes");

                entity.Property(e => e.MemoryTotalBytes).HasColumnName("Memory_Total_Bytes");

                entity.Property(e => e.OpenalprVersion)
                    .IsRequired()
                    .HasColumnName("Openalpr_Version")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessingThreadsActive).HasColumnName("Processing_Threads_Active");

                entity.Property(e => e.ProcessingThreadsConfigured).HasColumnName("Processing_Threads_Configured");

                entity.Property(e => e.SiteId)
                    .HasColumnName("Site_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemUptimeSeconds)
                    .HasColumnName("System_Uptime_Seconds")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.Timestamp).HasColumnType("numeric(13, 0)");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Images>(entity =>
            {
                entity.ToTable("Images", "Meta");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceCycles>(entity =>
            {
                entity.ToTable("InvoiceCycles", "ADMIN");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceStatement");

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvoiceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("InvoiceView");

                entity.Property(e => e.BillingProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDot)
                    .IsRequired()
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("Invoices", "Invoice");

                entity.Property(e => e.CompanyDot)
                    .IsRequired()
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Itemization>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("ITEMIZATION_pk")
                    .IsClustered(false);

                entity.ToTable("ITEMIZATION", "PAYMENT");

                entity.HasIndex(e => new { e.Module, e.EntityId, e.InvoiceId })
                    .HasName("ITEMIZATION_pk_2")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Itemization)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ITEMIZATION_STATEMENT_Id_fk");
            });

            modelBuilder.Entity<ItemizedStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemizedStatement");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.StateName)
                    .HasName("IX_HangFire_Job_StateName");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Job_ExpireAt");

                entity.Property(e => e.Arguments).IsRequired();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.InvocationData).IsRequired();

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.ToTable("JobParameter", "HangFire");

                entity.HasIndex(e => new { e.JobId, e.Name })
                    .HasName("IX_HangFire_JobParameter_JobIdAndName");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameter)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.ToTable("JobQueue", "HangFire");

                entity.HasIndex(e => new { e.Queue, e.FetchedAt })
                    .HasName("IX_HangFire_JobQueue_QueueAndFetchedAt");

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");

                entity.Property(e => e.Queue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_List_ExpireAt");

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_List_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value).HasColumnType("nvarchar(max)");
            });

            modelBuilder.Entity<Manifest>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("MANIFEST_pk")
                    .IsClustered(false);

                entity.ToTable("MANIFEST", "PAYMENT");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SkuName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuleGroups>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("GROUPS_pk")
                    .IsClustered(false);

                entity.ToTable("ModuleGroups", "SECURITY");

                entity.HasIndex(e => new { e.Module, e.GroupId })
                    .HasName("ModuleGroups_pk")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notes>(entity =>
            {
                entity.ToTable("Notes", "Meta");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoticeTemplates>(entity =>
            {
                entity.ToTable("NoticeTemplates", "Applications");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notices>(entity =>
            {
                entity.ToTable("Notices", "ADMIN");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NotificationLog>(entity =>
            {
                entity.ToTable("NotificationLog", "ADMIN");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.ToTable("Notifications", "ADMIN");

                entity.HasIndex(e => e.Name)
                    .HasName("IX_Notifications")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EventDetails)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Recepients).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentDetails>(entity =>
            {
                entity.ToTable("PaymentDetails", "Invoice");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountDetails)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationNum)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentChannel)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PERMISSIONS_pk")
                    .IsClustered(false);

                entity.ToTable("PERMISSIONS", "SECURITY");

                entity.HasIndex(e => new { e.StatusId, e.GroupId, e.RoleId })
                    .HasName("PERMISSIONS_pk_2")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermitConnections>(entity =>
            {
                entity.ToTable("PermitConnections", "Applications");
            });

            modelBuilder.Entity<PermitData>(entity =>
            {
                entity.ToTable("PermitData", "Applications");

                entity.Property(e => e.Alexpiration)
                    .HasColumnName("ALExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Glexpiration)
                    .HasColumnName("GLExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRenewal).HasColumnName("isRenewal");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wcexpiration)
                    .HasColumnName("WCExpiration")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PermitGrid>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PermitGrid");

                entity.Property(e => e.Alexpiration)
                    .HasColumnName("ALExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactEmail).HasMaxLength(100);

                entity.Property(e => e.ContactName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone).HasMaxLength(30);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Glexpiration)
                    .HasColumnName("GLExpiration")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRenewal).HasColumnName("isRenewal");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wcexpiration)
                    .HasColumnName("WCExpiration")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Permits>(entity =>
            {
                entity.ToTable("Permits", "ADMIN");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('NA')");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('NA')");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('NA')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TermsConditions).IsRequired();

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlateResults>(entity =>
            {
                entity.ToTable("PlateResults", "Camera");

                entity.Property(e => e.AgentType)
                    .HasColumnName("Agent_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentUid)
                    .IsRequired()
                    .HasColumnName("Agent_Uid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AgentVersion)
                    .HasColumnName("Agent_Version")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BestConfidence).HasColumnName("Best_Confidence");

                entity.Property(e => e.BestPlateNumber)
                    .IsRequired()
                    .HasColumnName("Best_Plate_Number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BestPlateRegion)
                    .IsRequired()
                    .HasColumnName("Best_Plate_Region")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.BestUuid)
                    .IsRequired()
                    .HasColumnName("Best_Uuid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CameraId)
                    .IsRequired()
                    .HasColumnName("Camera_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId)
                    .IsRequired()
                    .HasColumnName("Company_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .IsRequired()
                    .HasColumnName("Data_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EpochEnd)
                    .HasColumnName("Epoch_End")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.EpochStart)
                    .HasColumnName("Epoch_Start")
                    .HasColumnType("numeric(13, 0)");

                entity.Property(e => e.FrameEnd).HasColumnName("Frame_End");

                entity.Property(e => e.FrameStart).HasColumnName("Frame_Start");

                entity.Property(e => e.IsParked).HasColumnName("Is_Parked");

                entity.Property(e => e.TravelDirection).HasColumnName("Travel_Direction");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserData)
                    .IsRequired()
                    .HasColumnName("User_Data")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Possibilities>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("POSSIBILITIES_pk")
                    .IsClustered(false);

                entity.ToTable("POSSIBILITIES", "SECURITY");

                entity.HasIndex(e => new { e.StatusId, e.ParentId })
                    .HasName("POSSIBILITIES_pk_2")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fields).IsRequired();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("RECEIPT_pk")
                    .IsClustered(false);

                entity.ToTable("RECEIPT", "PAYMENT");

                entity.HasIndex(e => e.EntityId)
                    .HasName("RECEIPT_EntityId_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AccountNumber).HasMaxLength(100);

                entity.Property(e => e.ConfirmationNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RenewPermits>(entity =>
            {
                entity.ToTable("RenewPermits", "Applications");
            });

            modelBuilder.Entity<ReportInvoice>(entity =>
            {
                entity.ToTable("ReportInvoice", "Company");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoadNetworks>(entity =>
            {
                entity.HasKey(e => e.Fakeid);

                entity.Property(e => e.Fakeid).HasColumnName("fakeid");

                entity.Property(e => e.BegMp).HasColumnName("beg_mp");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(255);

                entity.Property(e => e.CountyCode).HasColumnName("county_code");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(255);

                entity.Property(e => e.DirFlag)
                    .HasColumnName("dir_flag")
                    .HasMaxLength(255);

                entity.Property(e => e.EndMp).HasColumnName("end_mp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Isdart)
                    .HasColumnName("isdart")
                    .HasMaxLength(255);

                entity.Property(e => e.Isfeeder)
                    .HasColumnName("isfeeder")
                    .HasMaxLength(255);

                entity.Property(e => e.Ispublish)
                    .HasColumnName("ispublish")
                    .HasMaxLength(255);

                entity.Property(e => e.Isschool)
                    .HasColumnName("isschool")
                    .HasMaxLength(255);

                entity.Property(e => e.MileLength).HasColumnName("mile_length");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.Needrebounday)
                    .HasColumnName("needrebounday")
                    .HasMaxLength(255);

                entity.Property(e => e.Needreinventory)
                    .HasColumnName("needreinventory")
                    .HasMaxLength(255);

                entity.Property(e => e.Networktype)
                    .HasColumnName("networktype")
                    .HasMaxLength(255);

                entity.Property(e => e.Objectid).HasColumnName("objectid");

                entity.Property(e => e.Percentdiff).HasColumnName("percentdiff");

                entity.Property(e => e.RbegMp).HasColumnName("rbeg_mp");

                entity.Property(e => e.RdType).HasColumnName("rd_type");

                entity.Property(e => e.RdwayId).HasColumnName("rdway_id");

                entity.Property(e => e.RendMp).HasColumnName("rend_mp");

                entity.Property(e => e.RmileLength).HasColumnName("rmile_length");

                entity.Property(e => e.RoadNo)
                    .HasColumnName("road_no")
                    .HasMaxLength(255);

                entity.Property(e => e.RoadNum).HasColumnName("road_num");

                entity.Property(e => e.SegmentLength).HasColumnName("segment_length");

                entity.Property(e => e.Subdevid)
                    .HasColumnName("subdevid")
                    .HasMaxLength(255);

                entity.Property(e => e.Updatedate)
                    .HasColumnName("updatedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updatedby)
                    .HasColumnName("updatedby")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RoleTypes>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("ROLETYPES_pk")
                    .IsClustered(false);

                entity.ToTable("RoleTypes", "SECURITY");

                entity.HasIndex(e => e.RoleId)
                    .HasName("ROLETYPES_RoleId_uindex")
                    .IsUnique();

                entity.HasIndex(e => e.RoleName)
                    .HasName("ROLETYPES_RoleName_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.IsInternal).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => new { e.Id, e.ExpireAt })
                    .HasName("IX_HangFire_Set_ExpireAt");

                entity.HasIndex(e => new { e.Key, e.Value })
                    .HasName("UX_HangFire_Set_KeyAndValue")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExpireAt, e.Value, e.Key })
                    .HasName("IX_HangFire_Set_Key");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.ToTable("Settings", "ADMIN");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkuList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkuList");

                entity.Property(e => e.ActivityCode).HasMaxLength(50);

                entity.Property(e => e.BillingProfile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyDot)
                    .HasColumnName("CompanyDOT")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationNum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode).HasMaxLength(50);

                entity.Property(e => e.Invoice)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode).HasMaxLength(50);

                entity.Property(e => e.SkuEventName)
                    .HasColumnName("SKU/Event Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkuStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SkuStatement");

                entity.Property(e => e.IsFixed).HasColumnName("isFixed");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Skus>(entity =>
            {
                entity.ToTable("Skus", "ADMIN");

                entity.Property(e => e.ActivityCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FixedAmount).HasMaxLength(50);

                entity.Property(e => e.FunctionCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RevenueCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserInputValue).HasMaxLength(50);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State", "HangFire");

                entity.HasIndex(e => e.JobId)
                    .HasName("IX_HangFire_State_JobId");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("STATEMENT_pk")
                    .IsClustered(false);

                entity.ToTable("STATEMENT", "PAYMENT");

                entity.HasIndex(e => e.InvoiceNumber)
                    .HasName("STATEMENT_InvoiceNumber_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("STATUS_PK")
                    .IsClustered(false);

                entity.ToTable("STATUS", "SECURITY");

                entity.HasIndex(e => new { e.Module, e.StatusName })
                    .HasName("STATUS_PK_2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Module, e.StatusValue })
                    .HasName("STATUS_PK_1")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NA')");

                entity.Property(e => e.IsSystem).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stories>(entity =>
            {
                entity.ToTable("Stories", "HELP");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SystemSettings>(entity =>
            {
                entity.ToTable("SystemSettings", "ADMIN");

                entity.Property(e => e.AllowFtp).HasColumnName("AllowFTP");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Topics>(entity =>
            {
                entity.ToTable("Topics", "HELP");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLoginHistory>(entity =>
            {
                entity.ToTable("UserLoginHistory", "Users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("IP")
                    .HasMaxLength(15);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLoginHistory)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserLoginHistory");
            });

            modelBuilder.Entity<UserPasswordRecovery>(entity =>
            {
                entity.ToTable("UserPasswordRecovery", "Users");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswordRecovery)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPasswordRecovery");
            });

            modelBuilder.Entity<UserPasswords>(entity =>
            {
                entity.ToTable("UserPasswords", "Users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserPasswords)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserPasswords");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "Users");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(30);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<VehicleStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VehicleStatement");

                entity.Property(e => e.Charge).HasColumnName("CHARGE");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehicles>(entity =>
            {
                entity.ToTable("Vehicles", "Applications");

                entity.HasIndex(e => new { e.Plate, e.State, e.Fiscal, e.PermitType })
                    .HasName("Vehicles_pk")
                    .IsUnique();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Make)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pax).HasColumnName("PAX");

                entity.Property(e => e.Plate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vin)
                    .IsRequired()
                    .HasColumnName("VIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
