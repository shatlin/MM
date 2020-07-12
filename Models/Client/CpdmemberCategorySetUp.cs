using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class CpdmemberCategorySetUp
    {
        public int Id { get; set; }
        public int RelatedToId { get; set; }
        public int RelatedRecordId { get; set; }
        public int? MemberCategoryId { get; set; }
        public int Cpdcount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MemberCategory MemberCategory { get; set; }
        public virtual RelatedTo RelatedTo { get; set; }
    }
    public partial class CpdmemberCategorySetUpConfiguration : IEntityTypeConfiguration<CpdmemberCategorySetUp>
    {
        public void Configure(EntityTypeBuilder<CpdmemberCategorySetUp> builder)
        {
            builder.ToTable("CPDMemberCategorySetUp");

            builder.Property(e => e.Cpdcount).HasColumnName("CPDCount");

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.HasOne(d => d.MemberCategory)
                .WithMany(p => p.CpdmemberCategorySetUp)
                .HasForeignKey(d => d.MemberCategoryId)
                .HasConstraintName("FK_CPDMemberCategorySetUp_MemberCategory");

            builder.HasOne(d => d.RelatedTo)
                .WithMany(p => p.CpdmemberCategorySetUp)
                .HasForeignKey(d => d.RelatedToId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CPDMemberCategorySetUp_RelatedTo");
        }

    }
    public static partial class Seeder
    {
        public static void SeedCpdmemberCategorySetUp(this ModelBuilder modelBuilder)
        {

        }
    }
}
