using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class DBEntryMaster
    {
        public DBEntryMaster()
        {
        }
        public int Id { get; set; }
        public string ConnectionString { get; set; }

    }

    public partial class ClientDBConnectionMasterConfiguration : IEntityTypeConfiguration<DBEntryMaster>
    {
        public void Configure(EntityTypeBuilder<DBEntryMaster> builder)
        {
            builder.ToTable("DBEntryMaster");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
        }
    }

    public static partial class Seeder
    {
        public static void SeedClientDBConnectionMaster(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBEntryMaster>()
            .HasData(new DBEntryMaster { Id = 1, ConnectionString = "Server = localhost;  Uid = root; Pwd = MMRootPwd2#;Database =mm_" }
        );

        }
    }



}
