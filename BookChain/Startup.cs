using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using BookChain.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BookChain.Models.Worker;

namespace BookChain
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Configure User and Identity Requirments
            ConfigureUserIdentificationSpecs(services);

            // Cookies and redirects
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.Cookie.Expiration = TimeSpan.FromDays(150);

                options.LoginPath = "/WorkersAuth/Login";

                options.AccessDeniedPath = "/WorkersAuth/AccessDenied";
                options.SlidingExpiration = true;
            });

            // Configure MVC
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Configure DB
            services.AddDbContext<BookChainContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("BookChainContext")));
        }

        private static void ConfigureUserIdentificationSpecs(IServiceCollection services)
        {
            services.AddIdentity<Worker, WorkerRole>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = true;
            }).AddUserManager<BookChainUserManager>()
                          .AddSignInManager<BookChainSignInManager>()
                          .AddEntityFrameworkStores<BookChainContext>()
                          .AddDefaultTokenProviders();

            services.AddScoped<UserManager<Worker>, BookChainUserManager>();
            services.AddScoped<BookChainUserManager>();
            services.AddTransient<UserManager<Worker>, BookChainUserManager>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, BookChainUserManager userManager)
        {
            app.UseStatusCodePagesWithReExecute("/Home/Error/", "?statusCode={0}");
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();

            BookChainInititalizer.SeedUsers(userManager);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
