using BManager.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
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
            services
                .AddDbContext<BManagerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BManager")));
            services.AddMvc();
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
