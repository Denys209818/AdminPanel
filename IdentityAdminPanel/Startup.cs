using IdentityAdminPanel.Constants;
using IdentityAdminPanel.Domain;
using IdentityAdminPanel.Domain.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAdminPanel
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
            services.AddControllersWithViews();

            services.AddDbContext<EFContext>((DbContextOptionsBuilder builder) => {
                builder.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddIdentity<AppUser, AppRole>((IdentityOptions opt) => {
                opt.Password.RequireDigit = false;
                opt.Password.RequiredLength = 5;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
                opt.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<EFContext>()
            .AddDefaultTokenProviders();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            var dirPath = Path.Combine(Directory.GetCurrentDirectory(), "images");
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            using (var scope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope()) 
            {
               var _roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<AppRole>>();
                if (!_roleManager.Roles.Any()) 
                {
                    var res1 = _roleManager.CreateAsync(new AppRole { 
                        Name = Roles.Vip
                    }).Result;

                    var res2 = _roleManager.CreateAsync(new AppRole
                    {
                        Name = Roles.User
                    }).Result;

                    var res3 = _roleManager.CreateAsync(new AppRole
                    {
                        Name = Roles.Admin
                    }).Result;
                }
            }

            app.UseStaticFiles(new StaticFileOptions
                {
                    RequestPath = "/images",
                    FileProvider = new PhysicalFileProvider(dirPath)
                });

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                    );
            });
        }
    }
}
