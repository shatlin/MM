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
            ClientOrganization = new HashSet<ClientOrganization>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<ClientOrganization> ClientOrganization { get; set; }
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
                new ClientType { Id = 1, Name = "Association - Business / Trade", Description = "Association - Business / Trade", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 2, Name = "Association - Chamber of commerce", Description = "Association - Chamber of commerce", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 3, Name = "Association - Community / HOA", Description = "Association - Community / HOA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 4, Name = "Association - Professional", Description = "Association - Professional", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 5, Name = "Association - Health", Description = "Association - Health", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 6, Name = "Association - Business / Trade", Description = "Association - Business / Trade", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 7, Name = "Association - Student/Alumni/PTA", Description = "Association - Student/Alumni/PTA", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 8, Name = "Association - Teachers", Description = "Association - Teachers", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 9, Name = "Church or Religious Community", Description = "Church or Religious Community", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 10, Name = "Club - Service", Description = "Club - Service", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 11, Name = "Club - Special Interest or Social", Description = "Club - Special Interest or Social", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 12, Name = " COVID - 19", Description = " COVID - 19", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 13, Name = "Event / Conference", Description = "Event / Conference", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 14, Name = "Foundation or Charity", Description = "Foundation or Charity", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 15, Name = "Other(blank template)", Description = "Other(blank template)", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 16, Name = "Political / Advocacy", Description = "Political / Advocacy", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 17, Name = "Subscription Site", Description = "Subscription Site", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new ClientType { Id = 18, Name = "Support / Assistance Services", Description = "Support / Assistance Services", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
                 );

        }
    }
}

