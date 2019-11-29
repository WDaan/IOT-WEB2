using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SessionDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //TODO 01: Routering instellen
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //TODO 03: cookies voor sessievariabelen toelaten
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                //Sessie 30 seconden levend houden
                options.IdleTimeout = TimeSpan.FromSeconds(30);
                //cookie instellingen
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
                options.Cookie.Name = "Vives.ICT.SessionDemo";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //TODO 04: Sessiemogelijkheden toevoegen
            app.UseSession();
            app.UseStaticFiles();

            //TODO 05: std routering gebruiken
            app.UseMvcWithDefaultRoute();        
        }
    }
}
