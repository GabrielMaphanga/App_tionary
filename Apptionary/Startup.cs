using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Apptionary.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Apptionary
{
    public class Startup
    {
        public Startup(IConfiguration configuration) =>
        Configuration = configuration;
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:ApptionaryApps:ConnectionString"]));
            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["Data:ApptionaryIdentity:ConnectionString"]));

           services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IAppsRepository,EFAppRepository>();
           
            services.AddMvc();
        }



        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute( 
                    name: null,
                    template: "{category}/Page{appPage:int}",
                    defaults: new { controller = "App", action = "List" }

                  );

                routes.MapRoute(  name: null,
                    template: "Page{AppPage:int}",
                    defaults: new
                    {    controller = "App",
                        action = "List",
                        productPage = 1
                    }
                    );
                routes.MapRoute(name: null, template: "{category}", defaults: new
                {
                    controller = "App",
                    action = "List",
                    productPage = 1
                });

                routes.MapRoute(
                         name: null,
                         template: "",
                    defaults: new
                    {
                        controller = "App",
                        action = "List",
                        productPage = 1
                    });
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
            });
      
        
           // IdentitySeedData.EnsurePopulated(app);
            SeedData.EnsurePopulated(app);
        }
    }
}
