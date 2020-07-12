using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class MemberType
    {
        public MemberType()
        {
            CpdmemberTypeSetUp = new HashSet<CpdmemberTypeSetUp>();
            LandingPage = new HashSet<LandingPage>();
            Member = new HashSet<Member>();
            PromotionDetail = new HashSet<PromotionDetail>();
        }

        public int Id { get; set; }
        public int MemberCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MemberCategory MemberCategory { get; set; }
        public virtual ICollection<CpdmemberTypeSetUp> CpdmemberTypeSetUp { get; set; }
        public virtual ICollection<LandingPage> LandingPage { get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<PromotionDetail> PromotionDetail { get; set; }
    }



    public partial class MemberTypeConfiguration : IEntityTypeConfiguration<MemberType>
    {
        public void Configure(EntityTypeBuilder<MemberType> builder)
        {
   builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description).HasMaxLength(200);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.HasOne(d => d.MemberCategory)
                    .WithMany(p => p.MemberType)
                    .HasForeignKey(d => d.MemberCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberType_MemberCategory");
        }

    }
    public static partial class Seeder
    {
        public static void SeedMemberType(this ModelBuilder modelBuilder)
        {

        }
    }
}
