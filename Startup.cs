using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnniesTeaShop.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AnniesTeaShop
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => 
                 options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            // Add support MVC to the project
            services.AddControllersWithViews();
            // Registering categories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            // Registerin Tea interface with the service to the program
            services.AddScoped<ITeaRepository, TeaRepository>();

            services.AddScoped<IPieRepository, PieRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // enables MVC routing
            app.UseRouting();

            // accepts collection of endpoints. Navigation to controller and actions
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    // question on the pattern makes the Id element optional
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
    }
