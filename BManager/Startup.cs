﻿using BManager.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BManager.Data.IRepositories;
using BManager.Data.Repositories;
using Newtonsoft.Json;
namespace BManager
{
    public class Startup
    {
        public IConfiguration Configuration { get;}
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Startup));
            services
                .AddDbContext<BManagerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BManagerDb")));
            services.AddMvc().AddNewtonsoftJson(x =>
            {
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                x.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });
            services.AddScoped<IPersonRepository, PersonRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if(env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseEndpoints(routes =>
            routes.MapControllerRoute(
                "Default",
                "{controller=Home}/{Action=Index}/{id?}"));
        }
    }
}
