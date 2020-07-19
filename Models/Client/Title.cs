using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;

namespace MM.ClientModels
{
    public partial class Title
    {
        public Title()
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

    public partial class TitleConfiguration : IEntityTypeConfiguration<Title>
    {
        public void Configure(EntityTypeBuilder<Title> builder)
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
        public static void SeedTitle(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Title>().HasData(
                new Title { Id = 1, Name = "Mr", Description = "Mr", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Title { Id = 2, Name = "Mrs", Description = "Mrs", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Title { Id = 3, Name = "Ms", Description = "Ms", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Title { Id = 4, Name = "Dr", Description = "Dr", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
              );
        }
    }
}
