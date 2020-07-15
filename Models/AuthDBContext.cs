using System;
using System.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace MM.ClientModels
{
    public partial class AuthDBContext : IdentityDbContext<ClientUser>
    {
     
        public AuthDBContext()
        {
           
        }


        public AuthDBContext(DbContextOptions<AuthDBContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            OnModelCreatingPartial(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if ( !optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("ConnectionStrings")["ClientDBContext"]);
            }
        }

   
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
