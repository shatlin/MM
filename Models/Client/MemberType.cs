using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;
namespace MM.ClientModels
{
    public partial class MemberType
    {
        public MemberType()
        {
            CpdmemberTypeSetUp = new HashSet<CpdmemberTypeSetUp>();
            LandingPage = new HashSet<LandingPage>();
            Member = new HashSet<MemberUser>();
            PromotionDetail = new HashSet<PromotionDetail>();
        }

        public int Id { get; set; }
        
        [Display(Name = "Member Category", Prompt = "Please select Member Category")]
        [Required(ErrorMessage = "Member Category is required")]
        public int MemberCategoryId { get; set; }

        [Display(Name = "Member Type Name", Prompt = "Please enter Member Type Name")]
        [Required(ErrorMessage = "Member Type Name is required")]
        public string Name { get; set; }

        [Display(Name = "Member Type Description", Prompt = "Please enter Member Type Description")]
        [Required(ErrorMessage = "Member Type Description is required")]
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual MemberCategory MemberCategory { get; set; }
        public virtual ICollection<CpdmemberTypeSetUp> CpdmemberTypeSetUp { get; set; }
        public virtual ICollection<LandingPage> LandingPage { get; set; }
        public virtual ICollection<MemberUser> Member { get; set; }
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
