using Areas.Services;
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
    public class Startup
    {
        public IWebHostEnvironment _env;

        public Startup(IWebHostEnvironment _env)
        {
            this._env = _env;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            if (_env.IsProduction())
            {
                services.AddTransient<ICampusService, StudentsServiceImpl>();
            }
            else
            {
                services.AddTransient<ICampusService, TeachersServiceImpl>();
            }
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
               endpoints.MapAreaControllerRoute(
                    name: "boys",
                    areaName: "Boys",
                    pattern: "Boys/{controller=Home}/{action=Index}/{id?}"
               );

               endpoints.MapAreaControllerRoute(
                    name: "girls",
                    areaName: "Girls",
                    pattern: "Girls/{controller=Home}/{action=Index}/{id?}"
               );

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
