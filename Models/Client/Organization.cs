using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Organization
    {
        public Organization()
        {
            Member = new HashSet<Member>();
            MemberAddress = new HashSet<MemberAddress>();
            MemberBranch = new HashSet<MemberBranch>();
            MemberPlanHistory = new HashSet<MemberPlanHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Acronym { get; set; }
        public string Description { get; set; }
        public string WebSite { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Member> Member { get; set; }
        public virtual ICollection<MemberAddress> MemberAddress { get; set; }
        public virtual ICollection<MemberBranch> MemberBranch { get; set; }
        public virtual ICollection<MemberPlanHistory> MemberPlanHistory { get; set; }
    }
    public partial class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
   builder.Property(e => e.Acronym).HasMaxLength(50);

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.WebSite).HasMaxLength(50);
        }

    }
    public static partial class Seeder
    {
        public static void SeedOrganization(this ModelBuilder modelBuilder)
        {

        }
    }
}


