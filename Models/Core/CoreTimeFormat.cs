using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreTimeFormat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }


    public partial class CoreTimeFormatConfiguration : IEntityTypeConfiguration<CoreTimeFormat>
    {
        public void Configure(EntityTypeBuilder<CoreTimeFormat> builder)
        {

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");
            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

        }


    }

    public static partial class Seeder
    {
        public static void SeedCoreTimeFormat(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreTimeFormat>().HasData
                (
                new CoreTimeFormat { Id = 1, Name = "12:00 AM/PM", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreTimeFormat { Id = 2, Name = "24 Hours", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }

                );
        }
    }
}
