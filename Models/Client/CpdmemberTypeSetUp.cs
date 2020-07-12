using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class CpdmemberTypeSetUp
    {
        public int Id { get; set; }
        public int RelatedToId { get; set; }
        public int RelatedRecordId { get; set; }
        public int? MemberTypeId { get; set; }
        public int Cpdcount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MemberType MemberType { get; set; }
        public virtual RelatedTo RelatedTo { get; set; }
    }

    public partial class CpdmemberTypeSetUpConfiguration : IEntityTypeConfiguration<CpdmemberTypeSetUp>
    {
        public void Configure(EntityTypeBuilder<CpdmemberTypeSetUp> builder)
        {
  builder.ToTable("CPDMemberTypeSetUp");

                builder.Property(e => e.Cpdcount).HasColumnName("CPDCount");

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.HasOne(d => d.MemberType)
                    .WithMany(p => p.CpdmemberTypeSetUp)
                    .HasForeignKey(d => d.MemberTypeId)
                    .HasConstraintName("FK_CPDMemberTypeSetUp_MemberType");

                builder.HasOne(d => d.RelatedTo)
                    .WithMany(p => p.CpdmemberTypeSetUp)
                    .HasForeignKey(d => d.RelatedToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CPDMemberTypeSetUp_RelatedTo");
        }

    }
    public static partial class Seeder
    {
        public static void SeedCpdmemberTypeSetUp(this ModelBuilder modelBuilder)
        {

        }
    }
}
