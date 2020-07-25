using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class FileType
    {
        public FileType()
        {
            MemberFile = new HashSet<MemberFile>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<MemberFile> MemberFile { get; set; }
    }

    public partial class FileTypeConfiguration : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
    builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
        }

    }
    public static partial class Seeder
    {
        public static void SeedFileType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FileType>().HasData(
                              new FileType { Id = 1, Name = "MS-Word", Description = "Microsoft Word", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                              new FileType { Id = 2, Name = "MS-Excel", Description = "Microsoft Excel", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                              new FileType { Id = 3, Name = "PDF", Description = "PDF", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                              new FileType { Id = 4, Name = "Zip", Description = "Zip File", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                              );
        }
    }
}
