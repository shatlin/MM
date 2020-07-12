using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class Currency
    {
        public Currency()
        {
            Client = new HashSet<ClientOrganization>();
            PaymentSetting = new HashSet<PaymentSetting>();
            PlanDetail = new HashSet<PlanDetail>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ClientOrganization> Client { get; set; }
        public virtual ICollection<PaymentSetting> PaymentSetting { get; set; }
        public virtual ICollection<PlanDetail> PlanDetail { get; set; }
    }
    public partial class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
 builder.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.Description).HasMaxLength(50);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Symbol)
                    .IsRequired()
                    .HasMaxLength(10);
        }

    }
    public static partial class Seeder
    {
        public static void SeedCurrency(this ModelBuilder modelBuilder)
        {

        }
    }
}
