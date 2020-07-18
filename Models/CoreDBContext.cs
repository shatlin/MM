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

        public virtual DbSet<ClientDbEntry> ClientDbentry { get; set; }
        public virtual DbSet<DbEntry> DbEntry { get; set; }
        public virtual DbSet<DBEntryMaster> DbEntryMaster { get; set; }
        public virtual DbSet<CoreAccountType> CoreAccountType { get; set; }
        public virtual DbSet<CoreAddress> CoreAddress { get; set; }
        public virtual DbSet<CoreAddressType> CoreAddressType { get; set; }
        public virtual DbSet<CoreBankingDetail> CoreBankingDetail { get; set; }
        public virtual DbSet<CoreBilling> CoreBilling { get; set; }
        public virtual DbSet<CoreCity> CoreCity { get; set; }
        public virtual DbSet<CoreCountry> CoreCountry { get; set; }
        public virtual DbSet<CoreCurrency> CoreCurrency { get; set; }
        public virtual DbSet<CoreDateSetting> CoreDateSetting { get; set; }
        public virtual DbSet<CoreDesignation> CoreDesignation { get; set; }
        public virtual DbSet<CoreGender> CoreGender { get; set; }
        public virtual DbSet<CoreInvoice> CoreInvoice { get; set; }
        public virtual DbSet<CoreInvoiceStatus> CoreInvoiceStatus { get; set; }
        public virtual DbSet<CorePaymentGateway> CorePaymentGateway { get; set; }
        public virtual DbSet<CorePermission> CorePermission { get; set; }
        public virtual DbSet<CorePlanDetail> CorePlanDetail { get; set; }
        public virtual DbSet<CorePlanFrequency> CorePlanFrequency { get; set; }
        public virtual DbSet<CorePlanMaster> CorePlanMaster { get; set; }
        public virtual DbSet<CoreReferralType> CoreReferralType { get; set; }
        public virtual DbSet<CoreRelatedTo> CoreRelatedTo { get; set; }
        public virtual DbSet<CoreRole> CoreRole { get; set; }
        public virtual DbSet<CoreRolePermissionXref> CoreRolePermissionXref { get; set; }
        public virtual DbSet<CoreState> CoreState { get; set; }
        public virtual DbSet<CoreTag> CoreTag { get; set; }
        public virtual DbSet<CoreTax> CoreTax { get; set; }
        public virtual DbSet<CoreTaxPolicy> CoreTaxPolicy { get; set; }
        public virtual DbSet<CoreTaxScope> CoreTaxScope { get; set; }
        public virtual DbSet<CoreTimeFormat> CoreTimeFormat { get; set; }
        public virtual DbSet<CoreTimeZone> CoreTimeZone { get; set; }
        public virtual DbSet<CoreTitle> CoreTitle { get; set; }
        public virtual DbSet<CoreUser> CoreUser { get; set; }
        public virtual DbSet<CoreUserLoginAudit> CoreUserLoginAudit { get; set; }
        public virtual DbSet<CoreUserRoleXref> CoreUserRoleXref { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["CoreDBContext"]);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientDbEntryConfiguration());
            modelBuilder.ApplyConfiguration(new DbEntryConfiguration());
            modelBuilder.ApplyConfiguration(new ClientDBConnectionMasterConfiguration());

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
                entity.Property(e => e.AccountName)
                 .IsRequired()
                 .HasMaxLength(50);

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

            modelBuilder.ApplyConfiguration(new CoreDesignationConfiguration()).SeedCoreDesignation();
            modelBuilder.ApplyConfiguration(new CoreReferralTypeConfiguration()).SeedCoreReferralType();
            modelBuilder.ApplyConfiguration(new CoreCountryConfiguration()).SeedCoreCountry();
            modelBuilder.ApplyConfiguration(new CoreStateConfiguration()).SeedCoreState();
            modelBuilder.ApplyConfiguration(new CoreCityConfiguration()).SeedCoreCity();
            modelBuilder.ApplyConfiguration(new CoreCurrencyConfiguration()).SeedCoreCurrency();
            modelBuilder.ApplyConfiguration(new CoreDateSettingConfiguration()).SeedCoreDateSetting();
            modelBuilder.ApplyConfiguration(new CoreGenderConfiguration()).SeedCoreGender();


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


            modelBuilder.ApplyConfiguration(new CoreTimeFormatConfiguration()).SeedCoreTimeFormat();
            modelBuilder.ApplyConfiguration(new CoreTimeZoneConfiguration()).SeedCoreTimeZone();
            modelBuilder.ApplyConfiguration(new CoreTitleConfiguration()).SeedCoreTitle();


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

            OnModelCreatingPartial(modelBuilder);
        }

      

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
