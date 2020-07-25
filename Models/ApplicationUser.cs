using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MM.ClientModels
{
    public partial class ApplicationUser: IdentityUser
    {

        
        public ApplicationUser()
        {
            ClientUser = new HashSet<ClientUser>();
            MemberUser = new HashSet<MemberUser>();
          
        }

        public int TitleId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDay { get; set; }
        public int GenderId { get; set; }

        [NotMapped] 
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Pwd", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPwd { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual Title Title { get; set; }

        public virtual ICollection<ClientUser> ClientUser { get; set; }
        public virtual ICollection<MemberUser> MemberUser { get; set; }

    }

    public partial class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

          

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.MiddleName)
                 .IsRequired(false)
                 .HasMaxLength(50);

            builder.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.BirthDay).IsRequired(false).HasColumnType("datetime");

            builder.HasOne(d => d.Gender)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Gender");

            builder.HasOne(d => d.Title)
                .WithMany(p => p.User)
                .HasForeignKey(d => d.TitleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Title");
         

        }


    }


}
