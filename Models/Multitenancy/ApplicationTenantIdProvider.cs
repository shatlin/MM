namespace MM.ClientModels
{
    public class ApplicationTenantIdProvider : TenantIdProvider<string>
    {
        public ApplicationTenantIdProvider(string tenantId) : base(tenantId)
        {
            
        }
    }
}