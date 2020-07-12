using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Member
    {
        public Member()
        {
            Billing = new HashSet<Billing>();
            Cpd = new HashSet<Cpd>();
            Donation = new HashSet<Donation>();
            EventAttendance = new HashSet<EventAttendance>();
            EventRegistration = new HashSet<EventRegistration>();
            Invoice = new HashSet<Invoice>();
            MarketingGroupXref = new HashSet<MarketingGroupXref>();
            MarketingProfileXref = new HashSet<MarketingProfileXref>();
            MemberAddress = new HashSet<MemberAddress>();
            MemberAffliationXref = new HashSet<MemberAffliationXref>();
            MemberBankingDetail = new HashSet<MemberBankingDetail>();
            MemberCommunicationPreference = new HashSet<MemberCommunicationPreference>();
            MemberFile = new HashSet<MemberFile>();
            MemberPlanHistory = new HashSet<MemberPlanHistory>();
            MemberQualificationXref = new HashSet<MemberQualificationXref>();
            PromotionResponse = new HashSet<PromotionResponse>();
            Refund = new HashSet<Refund>();
        }

        public int Id { get; set; }
        public int TitleId { get; set; }
        public int? MemberBranchId { get; set; }
        public int? OrganizationId { get; set; }
        public int? ReferralTypeId { get; set; }
        public int? OrganizationStructureId { get; set; }
        public string MemberCode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool EmailActivated { get; set; }
        public DateTime JoinDate { get; set; }
        public DateTime NextRenewalDate { get; set; }
        public bool MembershipConfirmed { get; set; }
        public DateTime ConfirmedDate { get; set; }
        public int? MemberStatusId { get; set; }
        public int? MemberLevelId { get; set; }
        public int? MemberTeamId { get; set; }
        public int MemberTypeId { get; set; }
        public int GenderId { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public bool IsBillingContact { get; set; }
        public bool IsBranchContact { get; set; }
        public bool TermAccepted { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual MemberBranch MemberBranch { get; set; }
        public virtual MemberLevel MemberLevel { get; set; }
        public virtual MemberStatus MemberStatus { get; set; }
        public virtual MemberTeam MemberTeam { get; set; }
        public virtual MemberType MemberType { get; set; }
        public virtual Organization Organization { get; set; }
        public virtual OrganizationStructure OrganizationStructure { get; set; }
        public virtual ReferralType ReferralType { get; set; }
        public virtual Title Title { get; set; }
        public virtual ICollection<Billing> Billing { get; set; }
        public virtual ICollection<Cpd> Cpd { get; set; }
        public virtual ICollection<Donation> Donation { get; set; }
        public virtual ICollection<EventAttendance> EventAttendance { get; set; }
        public virtual ICollection<EventRegistration> EventRegistration { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<MarketingGroupXref> MarketingGroupXref { get; set; }
        public virtual ICollection<MarketingProfileXref> MarketingProfileXref { get; set; }
        public virtual ICollection<MemberAddress> MemberAddress { get; set; }
        public virtual ICollection<MemberAffliationXref> MemberAffliationXref { get; set; }
        public virtual ICollection<MemberBankingDetail> MemberBankingDetail { get; set; }
        public virtual ICollection<MemberCommunicationPreference> MemberCommunicationPreference { get; set; }
        public virtual ICollection<MemberFile> MemberFile { get; set; }
        public virtual ICollection<MemberPlanHistory> MemberPlanHistory { get; set; }
        public virtual ICollection<MemberQualificationXref> MemberQualificationXref { get; set; }
        public virtual ICollection<PromotionResponse> PromotionResponse { get; set; }
        public virtual ICollection<Refund> Refund { get; set; }
    }
    public partial class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
 builder.Property(e => e.ConfirmedDate).HasColumnType("datetime");

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.JoinDate).HasColumnType("datetime");

                builder.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.MemberCode)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.NextRenewalDate).HasColumnType("datetime");

                builder.Property(e => e.Notes).HasMaxLength(1000);

                builder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.Photo).HasColumnType("blob");

                builder.HasOne(d => d.Gender)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Gender");

                builder.HasOne(d => d.MemberBranch)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberBranchId)
                    .HasConstraintName("FK_Member_MemberBranch");

                builder.HasOne(d => d.MemberLevel)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberLevelId)
                    .HasConstraintName("FK_Member_MemberLevel");

                builder.HasOne(d => d.MemberStatus)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberStatusId)
                    .HasConstraintName("FK_Member_MemberStatus");

                builder.HasOne(d => d.MemberTeam)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberTeamId)
                    .HasConstraintName("FK_Member_MemberTeam");

                builder.HasOne(d => d.MemberType)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.MemberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_MemberType");

                builder.HasOne(d => d.Organization)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Member_Organization");

                builder.HasOne(d => d.OrganizationStructure)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.OrganizationStructureId)
                    .HasConstraintName("FK_Member_OrganizationStructure");

                builder.HasOne(d => d.ReferralType)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.ReferralTypeId)
                    .HasConstraintName("FK_Member_ReferralType");

                builder.HasOne(d => d.Title)
                    .WithMany(p => p.Member)
                    .HasForeignKey(d => d.TitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Member_Title");
        }

    }
    public static partial class Seeder
    {
        public static void SeedMember(this ModelBuilder modelBuilder)
        {

        }
    }
}
