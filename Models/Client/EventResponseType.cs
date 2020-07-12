using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class EventResponseType
    {
        public EventResponseType()
        {
            EventRegistration = new HashSet<EventRegistration>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<EventRegistration> EventRegistration { get; set; }
    }

    public partial class EventResponseTypeConfiguration : IEntityTypeConfiguration<EventResponseType>
    {
        public void Configure(EntityTypeBuilder<EventResponseType> builder)
        {
               builder.Property(e => e.CreatedOn).HasColumnType("datetime");

                builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

        }

    }
    public static partial class Seeder
    {
        public static void SeedEventResponseType(this ModelBuilder modelBuilder)
        {

        }
    }
}
