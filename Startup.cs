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
/* This is Aji's Change*/
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
       

            services.AddIdentity<IdentityUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 12;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedAccount = true;
            }).AddEntityFrameworkStores<ClientDbContext>()
              .AddDefaultTokenProviders().AddDefaultUI();


            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Client/Account/Login";
                options.LogoutPath = "/Client/Account//Logout";
                options.AccessDeniedPath = "/Client/Account/AccessDenied";
            });

            services
                  .AddMvc()
                  .AddRazorPagesOptions(options =>
                  {
                      options.Conventions.AuthorizeFolder("/Client");
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
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
