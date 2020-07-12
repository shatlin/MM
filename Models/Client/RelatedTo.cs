using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class RelatedTo
    {
        public RelatedTo()
        {
            Billing = new HashSet<Billing>();
            Cpd = new HashSet<Cpd>();
            CpdmemberCategorySetUp = new HashSet<CpdmemberCategorySetUp>();
            CpdmemberLevelSetUp = new HashSet<CpdmemberLevelSetUp>();
            CpdmemberTeamSetUp = new HashSet<CpdmemberTeamSetUp>();
            CpdmemberTypeSetUp = new HashSet<CpdmemberTypeSetUp>();
            Invoice = new HashSet<Invoice>();
            Refund = new HashSet<Refund>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<Cpd> Cpd { get; set; }
        public virtual ICollection<CpdmemberCategorySetUp> CpdmemberCategorySetUp { get; set; }
        public virtual ICollection<CpdmemberLevelSetUp> CpdmemberLevelSetUp { get; set; }
        public virtual ICollection<CpdmemberTeamSetUp> CpdmemberTeamSetUp { get; set; }
        public virtual ICollection<CpdmemberTypeSetUp> CpdmemberTypeSetUp { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Refund> Refund { get; set; }
    }
    public partial class RelatedToConfiguration : IEntityTypeConfiguration<RelatedTo>
    {
        public void Configure(EntityTypeBuilder<RelatedTo> builder)
        {
 builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description).HasMaxLength(100);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name).HasMaxLength(30);
        }

    }
    public static partial class Seeder
    {
        public static void SeedRelatedTo(this ModelBuilder modelBuilder)
        {

        }
    }
}
