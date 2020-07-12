using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace MM.ClientModels
{
    public partial class ClientType
    {
        public ClientType()
        {
            //ClientUser = new HashSet<ClientUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        //public virtual ICollection<ClientUser> ClientUser { get; set; }
    }


    public partial class ClientTypeConfiguration : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(EntityTypeBuilder<ClientType> builder)
        {

            builder.Property(e => e.CreatedOn).HasColumnType("datetime");
            builder.Property(e => e.Description).HasMaxLength(200);
            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");
            builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

        }


    }

    public static partial class Seeder
    {
        public static void SeedClientType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientType>().HasData(
                new ClientType { Id = 1, Name = "Individual", Description = "Individual", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 2, Name = "Organization", Description = "Organization", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                 );

        }
    }
}
