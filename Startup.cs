using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Areas
{
    /// <summary>
    /// This is the class that will be used when the app will fire on startup.
    /// The endpoints have been modified so that we can access 3 diffrent areas.
    /// Each will supply the end user with a different page and the contents will also alter
    /// </summary>
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

            //Configure the endpoiints to allow for the access to the areas folders
            app.UseEndpoints(endpoints =>
            {
                //This route will supply the app with a path to the area called boys
               endpoints.MapAreaControllerRoute(
                    name: "boys",
                    areaName: "Boys",
                    pattern: "Boys/{controller=Home}/{action=Index}/{id?}"
               );

                //This route will supply the app with a path to the area called girls
                endpoints.MapAreaControllerRoute(
                    name: "girls",
                    areaName: "Girls",
                    pattern: "Girls/{controller=Home}/{action=Index}/{id?}"
               );

                //This route will supply the app with a path to the area called teachers
                endpoints.MapAreaControllerRoute(
                    name: "teachers",
                    areaName: "Teachers",
                    pattern: "Teachers/{controller=Home}/{action=Index}/{id?}"
               );

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
