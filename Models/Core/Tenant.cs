using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class Tenant
    {
        public Tenant()
        {
            TenantUserTenant = new HashSet<TenantUserTenant>();
        }

        public int Id { get; set; }
        public string ClientName { get; set; }
        public string DbName { get; set; }
        public string ConnectionString { get; set; }

        public virtual ICollection<TenantUserTenant> TenantUserTenant { get; set; }
    }

    public partial class TenantConfiguration : IEntityTypeConfiguration<Tenant>
    {
        public void Configure(EntityTypeBuilder<Tenant> builder)
        {

         

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ClientName)
            .IsRequired()
            .HasMaxLength(45)
            .IsUnicode(false);

            builder.Property(e => e.DbName)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

            builder.Property(e => e.ConnectionString)
                   .IsRequired()
                   .HasMaxLength(200)
                   .IsUnicode(false);

        }


    }
}
