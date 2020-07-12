using System;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MM.CoreModels
{
    public partial class CoreDBContext : DbContext
    {
        public CoreDBContext()
        {
        }

        public CoreDBContext(DbContextOptions<CoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientDbEntry> Clientdbentries { get; set; }
        public virtual DbSet<DbEntry> Dbentries { get; set; }
        public virtual DbSet<ClientDBConnectionMaster> ClientDBConnectionMasters { get; set; }

        public virtual DbSet<CoreAccountType> AccountType { get; set; }
        public virtual DbSet<CoreAddress> Address { get; set; }
        public virtual DbSet<CoreAddressType> AddressType { get; set; }
        public virtual DbSet<CoreBankingDetail> BankingDetail { get; set; }
        public virtual DbSet<CoreBilling> Billing { get; set; }
        public virtual DbSet<CoreCity> City { get; set; }
        public virtual DbSet<CoreCountry> Country { get; set; }
        public virtual DbSet<CoreCurrency> Currency { get; set; }
        public virtual DbSet<CoreDateSetting> DateSetting { get; set; }
        public virtual DbSet<CoreGender> Gender { get; set; }
        public virtual DbSet<CoreInvoice> Invoice { get; set; }
        public virtual DbSet<CoreInvoiceStatus> InvoiceStatus { get; set; }
        public virtual DbSet<CorePaymentGateway> PaymentGateway { get; set; }
        public virtual DbSet<CorePermission> Permission { get; set; }
        public virtual DbSet<CorePlanDetail> CorePlanDetail { get; set; }
        public virtual DbSet<CorePlanFrequency> CorePlanFrequency { get; set; }
        public virtual DbSet<CorePlanMaster> CorePlanMaster { get; set; }
        public virtual DbSet<CoreRelatedTo> RelatedTo { get; set; }
        public virtual DbSet<CoreRole> Role { get; set; }
        public virtual DbSet<CoreRolePermissionXref> RolePermissionXref { get; set; }
        public virtual DbSet<CoreState> State { get; set; }
        public virtual DbSet<CoreTag> Tag { get; set; }
        public virtual DbSet<CoreTax> Tax { get; set; }
        public virtual DbSet<CoreTaxPolicy> TaxPolicy { get; set; }
        public virtual DbSet<CoreTaxScope> TaxScope { get; set; }
        public virtual DbSet<CoreTimeFormat> TimeFormat { get; set; }
        public virtual DbSet<CoreTimeZone> TimeZone { get; set; }
        public virtual DbSet<CoreTitle> Title { get; set; }
        public virtual DbSet<CoreUser> User { get; set; }
        public virtual DbSet<CoreUserLoginAudit> UserLoginAudit { get; set; }
        public virtual DbSet<CoreUserRoleXref> UserRoleXref { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CoreDBContext"]);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreAccountType>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreAddress>(entity =>
            {
                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.BuidlingName).HasMaxLength(100);

                entity.Property(e => e.ComplexName).HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.FaxNumber).HasMaxLength(50);

                entity.Property(e => e.Gpscoordinates)
                    .HasColumnName("GPSCoordinates")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PostalCode).HasMaxLength(50);

                entity.Property(e => e.PrimaryContactNo).HasMaxLength(50);

                entity.Property(e => e.PrimaryEmail).HasMaxLength(50);

                entity.Property(e => e.SecondaryContactNo).HasMaxLength(50);

                entity.Property(e => e.SecondaryEmail).HasMaxLength(50);

                entity.Property(e => e.StreetName).HasMaxLength(100);

                entity.HasOne(d => d.CoreAddressType)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressType");

                entity.HasOne(d => d.CoreCity)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Address_City");

                entity.HasOne(d => d.CoreCountry)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.CoreState)
                    .WithMany(p => p.CoreAddress)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_State");
            });

            modelBuilder.Entity<CoreAddressType>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreBankingDetail>(entity =>
            {
                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.RoutingCode).HasMaxLength(50);

                entity.HasOne(d => d.CoreAccountType)
                    .WithMany(p => p.CoreBankingDetail)
                    .HasForeignKey(d => d.AccountTypeId)
                    .HasConstraintName("FK_BankingDetail_AccountType");
            });

            modelBuilder.Entity<CoreBilling>(entity =>
            {
                entity.Property(e => e.CommentsForPayer).HasMaxLength(1000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InternalNotes).HasMaxLength(1000);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PaidAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaidDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentAmount).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.PaymentDueDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentItem)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.CoreInvoice)
                    .WithMany(p => p.CoreBilling)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Billing_Invoice");

                entity.HasOne(d => d.CorePaymentGateway)
                    .WithMany(p => p.CoreBilling)
                    .HasForeignKey(d => d.PaymentGatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Billing_PaymentGateway");

                entity.HasOne(d => d.CoreRelatedTo)
                    .WithMany(p => p.CoreBilling)
                    .HasForeignKey(d => d.RelatedToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Billing_RelatedTo");
            });

            modelBuilder.Entity<CoreCity>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreCountry>(entity =>
            {
                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreCurrency>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CoreDateSetting>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreGender>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreInvoice>(entity =>
            {
                entity.Property(e => e.CommentsForPayer).HasMaxLength(1000);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.InternalNotes).HasMaxLength(1000);

                entity.Property(e => e.InvoiceAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceItem)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CoreInvoiceStatus)
                    .WithMany(p => p.CoreInvoice)
                    .HasForeignKey(d => d.InvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_InvoiceStatus");

                entity.HasOne(d => d.CorePaymentGateway)
                    .WithMany(p => p.CoreInvoice)
                    .HasForeignKey(d => d.PaymentGatewayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_PaymentGateway");

                entity.HasOne(d => d.CoreRelatedTo)
                    .WithMany(p => p.CoreInvoice)
                    .HasForeignKey(d => d.RelatedToId)
                    .HasConstraintName("FK_Invoice_RelatedTo");
            });

            modelBuilder.Entity<CoreInvoiceStatus>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CorePaymentGateway>(entity =>
            {
                entity.Property(e => e.ApicodeForMerchant)
                    .HasColumnName("APICodeForMerchant")
                    .HasMaxLength(100);

                entity.Property(e => e.CommisionPercentage).HasColumnType("decimal(6, 3)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.IdForMerchant).HasMaxLength(100);

                entity.Property(e => e.MerchantLocation).HasMaxLength(100);

                entity.Property(e => e.MerchantName).HasMaxLength(100);

                entity.Property(e => e.MerchantNumber).HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PasswordForMerchant).HasMaxLength(100);
            });

            modelBuilder.Entity<CorePermission>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CorePlanDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.CorePlanDetail)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanDetail_Currency");

                entity.HasOne(d => d.CorePlanFrequency)
                    .WithMany(p => p.CorePlanDetail)
                    .HasForeignKey(d => d.PlanFrequencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanDetail_PlanFrequency");

                entity.HasOne(d => d.CorePlanMaster)
                    .WithMany(p => p.CorePlanDetail)
                    .HasForeignKey(d => d.PlanMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlanDetail_PlanMaster");
            });

            modelBuilder.Entity<CorePlanFrequency>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CorePlanMaster>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreRelatedTo>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(30);
            });

            modelBuilder.Entity<CoreRole>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreRolePermissionXref>(entity =>
            {
                entity.ToTable("RolePermissionXRef");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.HasOne(d => d.CorePermission)
                    .WithMany(p => p.CoreRolePermissionXref)
                    .HasForeignKey(d => d.Permissionid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissionXRef_Permission");

                entity.HasOne(d => d.CoreRole)
                    .WithMany(p => p.CoreRolePermissionXref)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RolePermissionXRef_Role");
            });

            modelBuilder.Entity<CoreState>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreTag>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<CoreTax>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CoreTaxPolicy>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreTaxScope>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.TaxScopeCode)
                    .IsRequired()
                    .HasMaxLength(50);
            });

   

            modelBuilder.Entity<CoreTimeFormat>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreTimeZone>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CoreTitle>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CoreUser>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.CoreGender)
                    .WithMany(p => p.CoreUser)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Gender");

                entity.HasOne(d => d.CoreTitle)
                    .WithMany(p => p.CoreUser)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Title");
            });

            modelBuilder.Entity<CoreUserLoginAudit>(entity =>
            {
                entity.Property(e => e.LogoutTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CoreUserRoleXref>(entity =>
            {
                entity.ToTable("UserRoleXRef");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.CoreRole)
                    .WithMany(p => p.CoreUserRoleXref)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleXRef_Role");

                entity.HasOne(d => d.CoreUser)
                    .WithMany(p => p.CoreUserRoleXref)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoleXRef_User");
            });

            modelBuilder.ApplyConfiguration(new ClientDbEntryConfiguration());
            modelBuilder.ApplyConfiguration(new DbEntryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientDBConnectionMasterConfiguration());


            SeedData(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

      

        private void SeedData(ModelBuilder modelBuilder)
        {
         modelBuilder.Entity<ClientDBConnectionMaster>()
         .HasData(
         new ClientDBConnectionMaster { Id = 1,  ConnectionString = "Server = localhost;  Uid = root; Pwd = MMRootPwd2#;Database =mm_" }
         );
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
