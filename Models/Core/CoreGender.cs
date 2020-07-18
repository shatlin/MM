using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MM.CoreModels
{
    public partial class CoreGender
    {
        public CoreGender()
        {
            CoreUser = new HashSet<CoreUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<CoreUser> CoreUser { get; set; }
    }


    public partial class CoreGenderConfiguration : IEntityTypeConfiguration<CoreGender>
    {
        public void Configure(EntityTypeBuilder<CoreGender> builder)
        {
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(100);
        }

    }
    public static partial class Seeder
    {
        public static void SeedCoreGender(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreGender>().HasData(
           new CoreGender { Id = 1, Name = "Male", Description = "Male", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
          new CoreGender { Id = 2, Name = "Female", Description = "Female", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
         new CoreGender { Id = 3, Name = "Other", Description = "Other", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
           );

        }
    }
}


