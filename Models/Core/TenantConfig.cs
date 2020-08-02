using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class TenantConfig
    {
        public TenantConfig()
        {
        }
        public int Id { get; set; }
        public string ConnectionString { get; set; }

    }

    public partial class TenantConfigConfiguration : IEntityTypeConfiguration<TenantConfig>
    {
        public void Configure(EntityTypeBuilder<TenantConfig> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
        }
    }

    public static partial class Seeder
    {
        public static void SeedTenantConfig(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TenantConfig>()
            .HasData(new TenantConfig { Id = 1, ConnectionString = "Server = localhost;  Uid = root; Pwd = Aji@2020;Database =mm_" }
        );

        }
    }



}
