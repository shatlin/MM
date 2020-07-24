using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class MemberFile
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int FileTypeId { get; set; }
        public byte[] FileContent { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual FileType FileType { get; set; }
        public virtual MemberUser Member { get; set; }
    }
    public partial class MemberFileConfiguration : IEntityTypeConfiguration<MemberFile>
    {
        public void Configure(EntityTypeBuilder<MemberFile> builder)
        {
 builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000);

                builder.Property(e => e.FileContent).IsRequired();

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.HasOne(d => d.FileType)
                    .WithMany(p => p.MemberFile)
                    .HasForeignKey(d => d.FileTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberFile_FileType");

                builder.HasOne(d => d.Member)
                    .WithMany(p => p.MemberFile)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberFile_Member");
        }

    }
    public static partial class Seeder
    {
        public static void SeedMemberFile(this ModelBuilder modelBuilder)
        {

        }
    }
}

