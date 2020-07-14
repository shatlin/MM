using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class AddressType
    {
        public AddressType()
        {
            Address = new HashSet<Address>();
            MemberAddress = new HashSet<MemberAddress>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<MemberAddress> MemberAddress { get; set; }
    }




    public partial class AddressTypeConfiguration : IEntityTypeConfiguration<AddressType>
    {
        public void Configure(EntityTypeBuilder<AddressType> builder)
        {
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");

            builder.Property(e => e.Name).HasMaxLength(100);
        }

    }
    public static partial class Seeder
    {
        public static void SeedAddressType(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddressType>().HasData(
              new AccountType { Id = 1, Name = "Postal Address", Description = "Postal Address", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 2, Name = "Physical Address", Description = "Physical Account", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 3, Name = "Billing Address", Description = "Billing Address", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 4, Name = "Business Address", Description = "Business Address", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 5, Name = "Shipping Address", Description = "Shipping Address", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
              new AccountType { Id = 6, Name = "Contract Address", Description = "Contract Address", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
              );
        }
    }
}

