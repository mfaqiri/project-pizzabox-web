using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddScoped<UnitOfWork>();
            services.AddDbContext<PizzaBoxContext>(options =>
      {
        if (!string.IsNullOrWhiteSpace(Configuration.GetConnectionString("mssql")))
        {
          options.UseSqlServer(Configuration.GetConnectionString("mssql"), opts =>
          {
            opts.EnableRetryOnFailure(3);
          });
        }
        else
        {
          options.UseNpgsql(Configuration.GetConnectionString("pgsql"), opts =>
          {
            opts.EnableRetryOnFailure(3);
          });
        }
      });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
