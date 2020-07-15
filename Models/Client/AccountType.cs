using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class AccountType
    {
        public AccountType()
        {
            BankingDetail = new HashSet<BankingDetail>();
            MemberBankingDetail = new HashSet<MemberBankingDetail>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<BankingDetail> BankingDetail { get; set; }
        public virtual ICollection<MemberBankingDetail> MemberBankingDetail { get; set; }
    }


    public partial class AccountTypeConfiguration : IEntityTypeConfiguration<AccountType>
    {
        public void Configure(EntityTypeBuilder<AccountType> builder)
        {

          
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(100);
            
        }

    }
    public static partial class Seeder
    {
        public static void SeedAccountType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountType>().HasData(
              new AccountType { Id = 1, Name = "Savings Account", Description = "Savings Account", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 2, Name = "Cheque Account", Description = "Cheque Account", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 3, Name = "Corporate Account", Description = "Corporate Account", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 4, Name = "Business Account", Description = "Business Account", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
            );
        }
    }
}
