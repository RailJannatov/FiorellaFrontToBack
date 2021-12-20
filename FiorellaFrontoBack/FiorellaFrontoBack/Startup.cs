using EmailService;
using FiorellaFrontoBack.Areas.AdminPanel.Data;
using FiorellaFrontoBack.DataAccessLayer;
using FiorellaFrontoBack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontoBack
{
    public class Startup
    {
        public readonly IConfiguration _iconfiguration;
        private readonly IWebHostEnvironment _environment;
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            _iconfiguration = configuration;
            _environment = environment;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var emailConfig = _iconfiguration
            .GetSection("EmailConfiguration")
            .Get<EmailConfiguration>();
            services.AddSingleton(emailConfig);
            services.AddScoped<IEmailSender, EmailSender>();
           
            var connectionString = _iconfiguration.GetConnectionString("DefaultConnection");
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
            });
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString, builder =>
                 {
                     builder.MigrationsAssembly(nameof(FiorellaFrontoBack));
                 });
            }

            );
                services.Configure<DataProtectionTokenProviderOptions>(options =>
                options.TokenLifespan = TimeSpan.FromHours(2));
                services.AddIdentity<User, IdentityRole>(options =>
                {
                         options.Password.RequiredLength = 8;
                         options.User.RequireUniqueEmail = true;
                         options.Lockout.MaxFailedAccessAttempts = 5;
                         options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
                         options.Password.RequireDigit = false;
                         options.Password.RequireUppercase = false;
                         options.User.RequireUniqueEmail = true;

                 })
                .AddEntityFrameworkStores<AppDbContext>()
                .AddErrorDescriber<IdentityErrorResult>()
                .AddDefaultTokenProviders();


            services.AddMvc().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            Constants.ImageFolderPath = Path.Combine(_environment.WebRootPath, "img");
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            app.UseRouting();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("areas", "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
                
            });

        }
    }
}
