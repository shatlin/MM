using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class DbEntry
    {
        public DbEntry()
        {
            ClientDbEntry = new HashSet<ClientDbEntry>();
        }

        public int Id { get; set; }
        public string DbName { get; set; }
        public string ConnectionString { get; set; }

        public virtual ICollection<ClientDbEntry> ClientDbEntry { get; set; }
    }

    public partial class DbEntryConfiguration : IEntityTypeConfiguration<DbEntry>
    {
        public void Configure(EntityTypeBuilder<DbEntry> builder)
        {

            builder.ToTable("DbEntry");

            builder.HasKey(e => e.Id);

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
