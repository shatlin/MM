using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MM.ClientModels
{
    public partial class TimeFormat
    {
        public TimeFormat()
        {
            Client = new HashSet<ClientOrganization>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ClientOrganization> Client { get; set; }
    }

    public partial class TimeFormatConfiguration : IEntityTypeConfiguration<TimeFormat>
    {
        public void Configure(EntityTypeBuilder<TimeFormat> builder)
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
        public static void SeedTimeFormat(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TimeFormat>().HasData
                (
                new TimeFormat { Id = 1, Name = "12/03/2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 2, Name = "03/12/2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 3, Name = "03.12.2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 4, Name = "03-12-2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 5, Name = "03 Dec 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 6, Name = "03-Dec-2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 7, Name = "2020-12-03", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 8, Name = "Friday, December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 9, Name = "Fri, December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 10, Name = "December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 11, Name = "03 December 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new TimeFormat { Id = 12, Name = "3 Dec 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                );
        }
    }
}