using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class BankingDetail
    {
        public int Id { get; set; }
        public int AccountTypeId { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public string RoutingCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual AccountType AccountType { get; set; }
    }

public partial class BankingDetailConfiguration : IEntityTypeConfiguration<BankingDetail>
{
    public void Configure(EntityTypeBuilder<BankingDetail> builder)
    {
   builder.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100);

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.RoutingCode).HasMaxLength(50);

                builder.HasOne(d => d.AccountType)
                    .WithMany(p => p.BankingDetail)
                    .HasForeignKey(d => d.AccountTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankingDetail_AccountType");
    }

}
public static partial class Seeder
{
    public static void SeedBankingDetail(this ModelBuilder modelBuilder)
    {

    }
}
}
