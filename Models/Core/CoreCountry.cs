using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MM.CoreModels
{
    public partial class CoreCountry
    {
        public CoreCountry()
        {
            CoreAddress = new HashSet<CoreAddress>();
            CoreState = new HashSet<CoreState>();
        }

        public int Id { get; set; }
        public string ISO2Code { get; set; }
        public string ISO3Code { get; set; }
        public int? PhoneCode { get; set; }

        public string Name { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<CoreAddress> CoreAddress { get; set; }
        public virtual ICollection<CoreState> CoreState { get; set; }
    }



    public partial class CoreCountryConfiguration : IEntityTypeConfiguration<CoreCountry>
    {
        public void Configure(EntityTypeBuilder<CoreCountry> builder)
        {
            builder.Property(e => e.ISO2Code).HasMaxLength(2);
            builder.Property(e => e.ISO3Code).HasMaxLength(3);
            builder.Property(e => e.CreatedOn).HasColumnType("datetime");
            builder.Property(e => e.ModifiedOn).HasColumnType("datetime");
            builder.Property(e => e.Name).HasMaxLength(100);
        }

    }
    public static partial class Seeder
    {
        public static void SeedCoreCountry(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoreCountry>().HasData(

                new CoreCountry { Id = 1, ISO2Code = "ZA", ISO3Code = "ZAF", Name = "South Africa", PhoneCode = 27, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreCountry { Id = 2, ISO2Code = "AU", ISO3Code = "AUS", Name = "Australia", PhoneCode = 61, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreCountry { Id = 3, ISO2Code = "IN", ISO3Code = "IND", Name = "India", PhoneCode = 91, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreCountry { Id = 4, ISO2Code = "GB", ISO3Code = "GBR", Name = "United Kingdom", PhoneCode = 44, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new CoreCountry { Id = 5, ISO2Code = "US", ISO3Code = "USA", Name = "United States", PhoneCode = 1, CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now }
             );
        }
    }
}



namespace MM.ClientModels
{
    
}

