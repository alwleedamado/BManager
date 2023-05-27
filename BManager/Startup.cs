using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Infrastructure.Data;
using BManager.Infrastructure.Data.Repositories;

namespace BManager
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("FreelancerClient", polocy => polocy
            .WithOrigins("http://localhost:4200","https://bmanager.tk")
            .SetIsOriginAllowed(host => true)
            .AllowAnyMethod()
            .AllowAnyHeader())
            );
            services.AddAutoMapper(typeof(Startup));
            services
                .AddDbContext<BManagerDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("BManagerDb")));
            services.AddMvc().AddNewtonsoftJson(x =>
            {
                x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                x.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            });

            // Repos
            services.AddScoped<IFreelancerRepository, FreelancerRepository>();
            services.AddScoped<ISpecialityTypeRepository, SpecialityTypeRepository>();
            services.AddScoped<ITeamRepository, TeamRepository>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseCors("FreelancerClient");
            app.UseEndpoints(routes =>
            routes.MapControllerRoute(
                "Default",
                "{controller=Home}/{Action=Index}/{id?}"));
        }
    }
}
