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
            tenants = new CoreDBContext().Tenant.ToList();
        }
        public async Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
        {
            TenantContext<Tenant> tenantContext = null;

            var tenant = tenants.Where(t => context.Request.Host.Value.Contains(t.ClientName)).FirstOrDefault();

            if (tenant == null)
            {
                tenant = new Tenant { ClientName = "Default", DbName = "Default", ConnectionString = "Default" };
            }

            tenantContext = new TenantContext<Tenant>(tenant);

            return await Task.FromResult(tenantContext);
        }
    }
}


//public class MultitenancyOptions
//{
//    public ICollection<Tenant> Tenants { get; set; } = new CoreDBContext().Tenant.ToList();
//}

//public class TenantResolver : MemoryCacheTenantResolver<Tenant>
//{
//    private readonly ICollection<Tenant> tenants;

//    public TenantResolver(IMemoryCache cache, ILoggerFactory loggerFactory, IOptions<MultitenancyOptions> options)
//       : base(cache, loggerFactory)
//    {
//        this.tenants = options.Value.Tenants;
//    }

//    protected override string GetContextIdentifier(HttpContext context)
//    {
//        return context.Request.Host.Value.ToLower();
//    }

//    protected override MemoryCacheEntryOptions CreateCacheEntryOptions()
//    {
//        return new MemoryCacheEntryOptions()
//            .SetAbsoluteExpiration(new TimeSpan(0, 30, 0)); // Cache for 30 minutes
//    }

//    protected override IEnumerable<string> GetTenantIdentifiers(TenantContext<Tenant> context)
//    {
//        List<string> ss = new List<string>();
//        ss.Add(context.Tenant.ClientName);
//        return ss;
//    }

//    protected override Task<TenantContext<Tenant>> ResolveAsync(HttpContext context)
//    {
//        TenantContext<Tenant> tenantContext = null;

//        var tenant = tenants.Where(t => context.Request.Path.Value.Contains(t.ClientName)).FirstOrDefault();

//        if (tenant != null)
//        {
//            tenantContext = new TenantContext<Tenant>(tenant);
//        }

//        return Task.FromResult(tenantContext);
//    }
//}