using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MM.CoreModels
{
    public partial class ClientDbEntry
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int DbEntryId { get; set; }
        public virtual DbEntry DbEntry { get; set; }
    }

    public partial class ClientDbEntryConfiguration : IEntityTypeConfiguration<ClientDbEntry>
    {
        public void Configure(EntityTypeBuilder<ClientDbEntry> builder)
        {

            builder.ToTable("ClientDbEntry");

            builder.HasKey(e => e.Id);

            builder.HasIndex(e => e.DbEntryId)
                    .HasName("FK_ClientDBEntry_DBEntry_idx");

            builder.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false);

            builder.HasOne(d => d.DbEntry)
                    .WithMany(p => p.ClientDbEntry)
                    .HasForeignKey(d => d.DbEntryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClientDBEntry_DBEntry");
        }


    }
}
