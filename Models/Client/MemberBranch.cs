using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class MemberBranch
    {
        public MemberBranch()
        {
            Member = new HashSet<Member>();
            MemberAddress = new HashSet<MemberAddress>();
        }

        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Organization Organization { get; set; }
        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<MemberAddress> MemberAddress { get; set; }
    }
    public partial class MemberBranchConfiguration : IEntityTypeConfiguration<MemberBranch>
    {
        public void Configure(EntityTypeBuilder<MemberBranch> builder)
        {
  builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name).HasMaxLength(100);

                builder.HasOne(d => d.Organization)
                    .WithMany(p => p.MemberBranch)
                    .HasForeignKey(d => d.OrganizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberBranch_Organization");
        }

    }
    public static partial class Seeder
    {
        public static void SeedMemberBranch(this ModelBuilder modelBuilder)
        {

        }
    }
}
