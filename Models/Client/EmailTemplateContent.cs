using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class EmailTemplateContent
    {
        public int Id { get; set; }
        public int EmailTemplateNameId { get; set; }
        public string EmailContent { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual EmailTemplateName EmailTemplateName { get; set; }
    }
    public partial class EmailTemplateContentConfiguration : IEntityTypeConfiguration<EmailTemplateContent>
    {
        public void Configure(EntityTypeBuilder<EmailTemplateContent> builder)
        {
 builder.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.EmailContent)
                    .IsRequired()
                    .HasMaxLength(4000);

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.HasOne(d => d.EmailTemplateName)
                    .WithMany(p => p.EmailTemplateContent)
                    .HasForeignKey(d => d.EmailTemplateNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplateContent_EmailTemplateName");
        }

    }
    public static partial class Seeder
    {
        public static void SeedEmailTemplateContent(this ModelBuilder modelBuilder)
        {

        }
    }
}
