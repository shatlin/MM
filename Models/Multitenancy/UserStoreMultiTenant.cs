﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MM.ClientModels
{
    public class UserStoreMultiTenant<TUser, TRole, TKey, TTenantId> : UserStore<TUser, TRole, ClientDbContext, TKey>
        where TUser : IdentiyUserMultiTenant<TKey, TTenantId>
        where TRole : IdentiyRoleMultiTenant<TKey, TTenantId>
        where TKey : IEquatable<TKey>
        where TTenantId : IEquatable<TTenantId>
    {
        public TTenantId TenantId { get; set; }
        public UserStoreMultiTenant(ClientDbContext context, ITenantIdProvider<TTenantId> tenantProvider, IdentityErrorDescriber describer = null) : base(context, describer)
        {
            this.TenantId = tenantProvider.TenantId;
        }

        public override Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken = new CancellationToken())
        {
            user.TenantId = this.TenantId;
            return base.CreateAsync(user, cancellationToken);
        }
        public override Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(Users, u => u.NormalizedUserName == normalizedUserName && u.TenantId.Equals(this.TenantId), cancellationToken);
        }
        public override Task<TUser> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();
            return EntityFrameworkQueryableExtensions.FirstOrDefaultAsync(Users, u => u.NormalizedEmail == normalizedEmail && u.TenantId.Equals(this.TenantId), cancellationToken);
        }
    }
}