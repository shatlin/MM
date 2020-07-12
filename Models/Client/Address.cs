using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Address
    {
        public Address()
        {
            Event = new HashSet<Event>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int AddressTypeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string BuidlingName { get; set; }
        public string ComplexName { get; set; }
        public string StreetName { get; set; }
        public int? CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public string PostalCode { get; set; }
        public string PrimaryContactNo { get; set; }
        public string SecondaryContactNo { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string FaxNumber { get; set; }
        public string Gpscoordinates { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AddressType AddressType { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Event> Event { get; set; }
    }
    public partial class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
builder.Property(e => e.AddressLine1).HasMaxLength(100);

                builder.Property(e => e.AddressLine2).HasMaxLength(100);

                builder.Property(e => e.BuidlingName).HasMaxLength(100);

                builder.Property(e => e.ComplexName).HasMaxLength(100);

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.FaxNumber).HasMaxLength(50);

                builder.Property(e => e.Gpscoordinates)
                    .HasColumnName("GPSCoordinates")
                    .HasMaxLength(50);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.PostalCode).HasMaxLength(50);

                builder.Property(e => e.PrimaryContactNo).HasMaxLength(50);

                builder.Property(e => e.PrimaryEmail).HasMaxLength(50);

                builder.Property(e => e.SecondaryContactNo).HasMaxLength(50);

                builder.Property(e => e.SecondaryEmail).HasMaxLength(50);

                builder.Property(e => e.StreetName).HasMaxLength(100);

                builder.HasOne(d => d.AddressType)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_AddressType");

                builder.HasOne(d => d.City)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Address_City");

                builder.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Country");

                builder.HasOne(d => d.State)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_State");
           
        }

    }
    public static partial class Seeder
    {
        public static void SeedAddress(this ModelBuilder modelBuilder)
        {

        }
    }
}

