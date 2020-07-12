using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MM.ClientModels
{
    public partial class ClientUser
    {
        public ClientUser()
        {
            ClientPlanHistory = new HashSet<ClientPlanHistory>();
            Cpd = new HashSet<Cpd>();
            Event = new HashSet<Event>();
            EventRoleUserXref = new HashSet<EventRoleUserXref>();
            UserRoleXref = new HashSet<UserRoleXref>();
        }

        public int Id { get; set; }
        public int TitleId { get; set; }

        //public int ClientTypeId { get; set; }
        [Display(Name = "Email Id (Required)", Prompt = "Please enter your email id")]
        [Required(ErrorMessage = "Email Id is required")]
        public string Email { get; set; }

        [Display(Name = "Password (Required)", Prompt = "Please enter your Password")]
        [Required(ErrorMessage = "Passwrord is required")]
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool EmailActivated { get; set; }
        public bool PrimaryContact { get; set; }
        public bool BillingContact { get; set; }
        public int? DesignationId { get; set; }
        public int RoleId { get; set; }
        public int? ReferralTypeId { get; set; }
        public string Notes { get; set; }
        public int GenderId { get; set; }
        public bool IsInternalUser { get; set; }
        public bool TermsAccepted { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        //public virtual ClientType ClientType { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual ReferralType ReferralType { get; set; }
        public virtual Role Role { get; set; }
        public virtual Title Title { get; set; }
        public virtual ICollection<ClientPlanHistory> ClientPlanHistory { get; set; }
        public virtual ICollection<Cpd> Cpd { get; set; }
        public virtual ICollection<Event> Event { get; set; }
        public virtual ICollection<EventRoleUserXref> EventRoleUserXref { get; set; }
        public virtual ICollection<UserRoleXref> UserRoleXref { get; set; }
    }

    public partial class ClientUserConfiguration : IEntityTypeConfiguration<ClientUser>
    {
        public void Configure(EntityTypeBuilder<ClientUser> builder)
        {

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.MiddleName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Notes)
                   .HasMaxLength(1000);

            builder.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(d => d.Designation)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.DesignationId)
                .HasConstraintName("FK_User_Designation");

            builder.HasOne(d => d.Gender)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Gender");

            builder.HasOne(d => d.ReferralType)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.ReferralTypeId)
                .HasConstraintName("FK_User_ReferralType");

            builder.HasOne(d => d.Role)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Role");

            builder.HasOne(d => d.Title)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Title");

            //builder.HasOne(d => d.ClientType)
            //     .WithMany(p => p.ClientUser)
            //     .HasForeignKey(d => d.ClientTypeId)
            //     .OnDelete(DeleteBehavior.ClientSetNull)
            //     .HasConstraintName("FK_Client_ClientType");

        }

      
    }
    public static partial class Seeder
    {
        public static void SeedClientUser(this ModelBuilder modelBuilder)
        {

        }
    }

}
