using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MM.ClientModels
{
    public class IdentiyRoleMultiTenant<TKey, TTenantId> : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
        where TTenantId : IEquatable<TTenantId>
    {
        private string roleName;

        public IdentiyRoleMultiTenant(string roleName)
        {
            this.roleName = roleName;
        }

        public TTenantId TenantId { get; set; }
    }
}