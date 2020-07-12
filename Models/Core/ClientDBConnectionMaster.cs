using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace MM.CoreModels
{
    public partial class ClientDBConnectionMaster
    {
        public ClientDBConnectionMaster()
        {
        }

        public int Id { get; set; }
        public string ConnectionString { get; set; }

    }

    public partial class ClientDBConnectionMasterConfiguration : IEntityTypeConfiguration<ClientDBConnectionMaster>
    {
        public void Configure(EntityTypeBuilder<ClientDBConnectionMaster> builder)
        {

            builder.ToTable("ClientDBConnectionMaster");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.ConnectionString)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
           
        

    }
    }
}
