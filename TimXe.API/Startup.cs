using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimXe.Data.Context;

namespace TimXe.API
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

            // Read the connection string from appsettings.
            string dbConnectionString = this.Configuration.GetConnectionString(Configuration["Environment"]);

            // Read the connection string from appsettings.
            services.AddDbContext<SWD_SE1413_TIMXEContext>(options =>
                options.UseSqlServer(dbConnectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            //Register DBcontext for migration
            services.AddDbContext<SWD_SE1413_TIMXEContext>(options => options.UseSqlServer(dbConnectionString));

            // Register your regular repositories
            // services.AddScoped<IDiameterRepository, DiameterRepository>();
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TimXe.API", Version = "v1" });
            });

            services.AddCors(options =>
                options.AddDefaultPolicy(
                builder => builder.AllowAnyOrigin()
            ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "TimXe.API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
