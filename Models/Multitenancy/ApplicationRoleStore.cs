using System;

namespace MM.ClientModels
{
    public class ApplicationRoleStore : RoleStoreMultiTenant<ApplicationRole, string, string>
    {
        public ApplicationRoleStore(ClientDbContext context, ApplicationTenantIdProvider tenantProvider) : base(context, tenantProvider)
        {
            this.TenantKey = tenantProvider.TenantId;
        }
    }
}