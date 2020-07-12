using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class ReferralType
    {
        public ReferralType()
        {
            Member = new HashSet<Member>();
            User = new HashSet<ClientUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<ClientUser> User { get; set; }
    }


    public partial class ReferralTypeConfiguration : IEntityTypeConfiguration<ReferralType>
    {
        public void Configure(EntityTypeBuilder<ReferralType> builder)
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
        public static void SeedReferralType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReferralType>().HasData(
                new ReferralType { Id = 1, Name = "Google", Description = "Google", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ReferralType { Id = 2, Name = "Facebook", Description = "Facebook", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ReferralType { Id = 3, Name = "Twitter", Description = "Twitter", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ReferralType { Id = 4, Name = "TV", Description = "TV", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ReferralType { Id = 5, Name = "Friends", Description = "Friends", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ReferralType { Id = 6, Name = "Other", Description = "Other", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                 );

        }
    }
}

