using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MM.CoreModels
{
    public partial class TenantUserTenant
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int TenantId { get; set; }
        public virtual Tenant Tenant { get; set; }
    }

    public partial class TenantUserTenantConfiguration : IEntityTypeConfiguration<TenantUserTenant>
    {
        public void Configure(EntityTypeBuilder<TenantUserTenant> builder)
        {

            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.TenantId)
                    .HasName("FK_TenantUserTenant_Tenant_idx");

            builder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

            builder.HasOne(d => d.Tenant)
                    .WithMany(p => p.TenantUserTenant)
                    .HasForeignKey(d => d.TenantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TenantUserTenant_Tenant");
        }


    }
}
