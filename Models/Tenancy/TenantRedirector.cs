using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MM.CoreModels;
using SaasKit.Multitenancy;

namespace MM.TenantModels
{
    public class TenantRedirector
    {
        //private readonly RequestDelegate _next;

        //public TenantRedirector(RequestDelegate next)
        //{
        //    _next = next;
        //}

        //public async Task InvokeAsync(HttpContext context)
        //{
        //    if (context.GetTenant<Tenant>()!=null)
        //    {
        //        context.Response.Redirect("/Member/index");
        //        return;
        //    }
        //}
    }

    public static class TenantRedirectorExtensions
    {
        //public static IApplicationBuilder UseTenantRedirector(this IApplicationBuilder builder)
        //{
        //    return builder.UseMiddleware<TenantRedirector>();
        //}
    }

}
