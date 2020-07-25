using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.CoreModels
{
    public partial class CoreDateSetting
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

       
    }

    public partial class CoreDateSettingConfiguration : IEntityTypeConfiguration<CoreDateSetting>
    {
        public void Configure(EntityTypeBuilder<CoreDateSetting> builder)
        {
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Name).IsRequired().HasMaxLength(40);
        }

    }
    public static partial class Seeder
    {
        public static void SeedCoreDateSetting(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreDateSetting>().HasData
          (
          new CoreDateSetting { Id = 1, Name = "12/03/2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 2, Name = "03/12/2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 3, Name = "03.12.2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 4, Name = "03-12-2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 5, Name = "03 Dec 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 6, Name = "03-Dec-2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 7, Name = "2020-12-03", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 8, Name = "Friday, December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 9, Name = "Fri, December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 10, Name = "December 03, 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 11, Name = "03 December 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreDateSetting { Id = 12, Name = "3 Dec 2020", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
          );
        }
    }
}