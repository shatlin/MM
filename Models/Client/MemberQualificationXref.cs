using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class MemberQualificationXref
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int? QualificationId { get; set; }
        public string MemberSpecificQualificationName { get; set; }
        public string Description { get; set; }
        public DateTime QualificationFrom { get; set; }
        public DateTime QualificationTill { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Member Member { get; set; }
        public virtual Qualification Qualification { get; set; }
    }

    public partial class MemberQualificationXrefConfiguration : IEntityTypeConfiguration<MemberQualificationXref>
    {
        public void Configure(EntityTypeBuilder<MemberQualificationXref> builder)
        {
   builder.ToTable("MemberQualificationXRef");

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                builder.Property(e => e.MemberSpecificQualificationName).HasMaxLength(100);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.QualificationFrom).HasColumnType("datetime");

                builder.Property(e => e.QualificationTill).HasColumnType("datetime");

                builder.HasOne(d => d.Member)
                    .WithMany(p => p.MemberQualificationXref)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberQualificationXRef_Member");

                builder.HasOne(d => d.Qualification)
                    .WithMany(p => p.MemberQualificationXref)
                    .HasForeignKey(d => d.QualificationId)
                    .HasConstraintName("FK_MemberQualificationXRef_Qualification");
        }

    }
    public static partial class Seeder
    {
        public static void SeedMemberQualificationXref(this ModelBuilder modelBuilder)
        {

        }
    }
}
