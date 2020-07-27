using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using MM.CoreModels;
using MM.ClientModels;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using MM.TenantModels;
using Microsoft.AspNetCore.Http;
using SaasKit.Multitenancy;
using Microsoft.AspNetCore.Identity.UI.Services;
using Services.Email;
namespace MM
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddNewtonsoftJson();
            services.AddRazorPages();
            services.AddDbContext<CoreDBContext>(options => options.UseMySql(Configuration.GetConnectionString("CoreDBContext")));
            services.AddDbContext<ClientDbContext>(options => options.UseMySql(Configuration.GetConnectionString("ClientDBContext")));

            services.AddMultitenancy<Tenant, TenantResolver>();
            services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 12;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedAccount = true;
            }).AddEntityFrameworkStores<ClientDbContext>()
              .AddDefaultTokenProviders().AddDefaultUI();

            //services.Configure<RouteOptions>(options =>
            //{
            //    options.LowercaseUrls = true;
            //    options.LowercaseQueryStrings = false;
            //    options.AppendTrailingSlash = true;
            //    //options.ContraintMap.Add("Custom", typeof(CustomConstraint));
            //});

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Client/Account/Login";
                options.LogoutPath = "/Client/Account//Logout";
                options.AccessDeniedPath = "/Client/Account/AccessDenied";
            });


            services.AddTransient<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    Configuration["EmailSender:Host"],
                    Configuration.GetValue<int>("EmailSender:Port"),
                    Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    Configuration["EmailSender:UserName"],
                    Configuration["EmailSender:Password"]
                )
            );

            services
                  .AddMvc()
                  .AddRazorPagesOptions(options =>
                  {
                      options.Conventions.AuthorizeFolder("/Client");
                  });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("SetUp", policy => policy.RequireClaim("Setup"));
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("AllowSetupDelete", policy => policy.RequireClaim("Setup", "Delete"));
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMultitenancy<Tenant>();

            //app.Use(async (ctx, next) =>
            //{
            //    if (ctx.GetTenant<Tenant>() != null)
            //    {
            //        var tenant = ctx.GetTenant<Tenant>();
            //        ctx.Response.Redirect("/member/index", true);
            //        ctx.Items.Add("CURRENT_TENANT", tenant);
            //    }
            //    else
            //    {
            //     await next();
            //    }
            //});

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
