using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class CoreTitle
    {
        public CoreTitle()
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

    public partial class CoreTitleConfiguration : IEntityTypeConfiguration<CoreTitle>
    {
        public void Configure(EntityTypeBuilder<CoreTitle> builder)
        {

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");
            builder.Property(e => e.Description).HasMaxLength(200);
            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

        }


    }

    public static partial class Seeder
    {
        public static void SeedCoreTitle(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreTitle>().HasData(
                new CoreTitle { Id = 10, Name = "Mr", Description = "Mr", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreTitle { Id = 20, Name = "Mrs", Description = "Mrs", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreTitle { Id = 30, Name = "Ms", Description = "Ms", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreTitle { Id = 40, Name = "Dr", Description = "Dr", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
              );

        }
    }
}
