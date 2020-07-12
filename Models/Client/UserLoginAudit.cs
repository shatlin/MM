using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace MM.ClientModels
{
    public partial class UserLoginAudit
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
    }



    public partial class UserLoginAuditConfiguration : IEntityTypeConfiguration<UserLoginAudit>
    {
        public void Configure(EntityTypeBuilder<UserLoginAudit> builder)
        {
  builder.Property(e => e.LogoutTime).HasColumnType("datetime");
        }

    }
    public static partial class Seeder
    {
        public static void SeedUserLoginAudit(this ModelBuilder modelBuilder)
        {

        }
    }
}


