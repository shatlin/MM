using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MM.ClientModels
{
public class ApplicationUserStore<ApplicationUser> : UserStore  
    {
        public ApplicationUserStore(DbContext context)
          : base(context)
        {
        }
        public int TenantId { get; set; }
    }


}
