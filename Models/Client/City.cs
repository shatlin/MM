using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class City
    {
        public City()
        {
            Address = new HashSet<Address>();
        }

        public int Id { get; set; }
        public int? StateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual State State { get; set; }
        public virtual ICollection<Address> Address { get; set; }
    }

    public partial class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(100);

            builder.HasOne(d => d.State)
                .WithMany(p => p.City)
                .HasForeignKey(d => d.StateId)
                .HasConstraintName("FK_City_State");
        }

    }
    public static partial class Seeder
    {
        public static void SeedCity(this ModelBuilder modelBuilder)
        {

        }
    }
}
