using System;

namespace MM.ClientModels
{
    public class ApplicationUserStore : UserStoreMultiTenant<ApplicationUser, ApplicationRole, string, string>
    {
        public ApplicationUserStore(ClientDbContext context, ApplicationTenantIdProvider tenantProvider) : base(context, tenantProvider)
        {
            this.TenantId = tenantProvider.TenantId;
        }
    }
}