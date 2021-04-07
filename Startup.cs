using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MummyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MummyProject
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

            services.AddDbContext<MummyDbContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:BurialConnection"]);
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Burials}/{action=Index}/{id?}");

            endpoints.MapControllerRoute("page",
                "{page:int}",
                    new { Controller = "Burials", action = "Index" });

                endpoints.MapControllerRoute("age",
                    "{age}",
                    new { Controller = "Burials", action = "Index", page = 1 });

                endpoints.MapControllerRoute("pagination",
                    "Burials/{page}",
                    new { Controller = "Burials", action = "Index" });





            });
        }
    }
}
