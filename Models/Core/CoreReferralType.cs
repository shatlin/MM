using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.CoreModels
{
    public partial class CoreReferralType
    {
      

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

      
    }


    public partial class CoreReferralTypeConfiguration : IEntityTypeConfiguration<CoreReferralType>
    {
        public void Configure(EntityTypeBuilder<CoreReferralType> builder)
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
        public static void SeedCoreReferralType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreReferralType>().HasData(
                new CoreReferralType { Id = 1, Name = "Google", Description = "Google", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreReferralType { Id = 2, Name = "Facebook", Description = "Facebook", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreReferralType { Id = 3, Name = "Twitter", Description = "Twitter", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreReferralType { Id = 4, Name = "TV", Description = "TV", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreReferralType { Id = 5, Name = "Friends", Description = "Friends", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreReferralType { Id = 6, Name = "Other", Description = "Other", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                 );

        }
    }
}

