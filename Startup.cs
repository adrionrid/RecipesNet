using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using RecipesNet.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipesNet.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Principal;

namespace RecipesNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private readonly string RequireRoleAdministrator = "RequireRoleAdministrator";
        private readonly string RequireRoleModerator = "RequireRoleModerator";
        private readonly string RoleAdministrator = "Administrator"; 
        private readonly string RoleModerator = "Moderator";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddRazorPages()
                .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Recipes")
                        .AllowAnonymousToPage("/Recipes/Index")
                        .AllowAnonymousToPage("/Recipes/Details");
                    options.Conventions.AuthorizeFolder("/Ingredients", RequireRoleModerator)
                        .AllowAnonymousToPage("/Ingredients/Index");
                    options.Conventions.AuthorizeFolder("/Cuisines", RequireRoleModerator);
                    options.Conventions.AuthorizeFolder("/DishTypes", RequireRoleModerator);
                    options.Conventions.AuthorizeFolder("/IngredientTypes", RequireRoleModerator);
                    options.Conventions.AuthorizeFolder("/Identity", RequireRoleAdministrator);
                });
            services.AddAuthorization(options =>
            {
                options.AddPolicy(RequireRoleAdministrator,
                     policy => policy.RequireRole(RoleAdministrator));
                options.AddPolicy(RequireRoleModerator,
                     policy => policy.RequireRole(RoleAdministrator, RoleModerator));
            });
            services.AddServerSideBlazor();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context.Database.Migrate();
            }
            SeedDataRoles.Initialize(app.ApplicationServices);
            SeedData.Initialize(app.ApplicationServices);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
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
                endpoints.MapBlazorHub();
            });
        }
    }
}
