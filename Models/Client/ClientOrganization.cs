using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class ClientOrganization
    {
        public int Id { get; set; }
        public int ClientTypeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool AgreedToTerms { get; set; }
        public bool IsActive { get; set; }
        public int? DateSettingId { get; set; }
        public int? TimeFormatId { get; set; }
        public int? TimeZoneId { get; set; }
        public int? CurrencyId { get; set; }
        public int? CurrencyDecimalPlaces { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        
        public virtual Currency Currency { get; set; }
        public virtual DateSetting DateSetting { get; set; }
        public virtual TimeFormat TimeFormat { get; set; }
        public virtual TimeZone TimeZone { get; set; }
        public virtual BillingCommunication BillingCommunication { get; set; }
    }
    public partial class ClientOrganizationConfiguration : IEntityTypeConfiguration<ClientOrganization>
    {
        public void Configure(EntityTypeBuilder<ClientOrganization> builder)
        {
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");


            builder.Property(e => e.Description).HasMaxLength(200);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);




            builder.HasOne(d => d.Currency)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.CurrencyId)
                .HasConstraintName("FK_Client_Currency");

            builder.HasOne(d => d.DateSetting)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.DateSettingId)
                .HasConstraintName("FK_Client_DateSetting");

            builder.HasOne(d => d.TimeFormat)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.TimeFormatId)
                .HasConstraintName("FK_Client_TimeFormat");

            builder.HasOne(d => d.TimeZone)
                .WithMany(p => p.Client)
                .HasForeignKey(d => d.TimeZoneId)
                .HasConstraintName("FK_Client_TimeZone");
        }

    }
    public static partial class Seeder
    {
        public static void SeedClientOrganization(this ModelBuilder modelBuilder)
        {

        }
    }
}

