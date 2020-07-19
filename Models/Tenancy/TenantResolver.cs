using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM.CoreModels;
using SaasKit.Multitenancy;

namespace MM.TenantModels
{
    public class TenantResolver : ITenantResolver<Tenant>
    {
        private readonly ICollection<Tenant> tenants;
        public TenantResolver()
        {
            tenants =new CoreDBContext().Tenant.ToList();
        }
        public async Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
        {
            TenantContext<Tenant> tenantContext = null;
            
            var tenant = tenants.Where(t=> context.Request.Host.Value.Contains(t.ClientName)).FirstOrDefault();
            
            if (tenant != null)
            {
                tenantContext = new TenantContext<Tenant>(tenant);
            }
            return await Task.FromResult(tenantContext);
        }
    }
}
