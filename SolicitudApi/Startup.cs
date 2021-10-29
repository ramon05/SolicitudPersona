using GenericApi.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SolicitudApi.BI.Config;
using SolicitudApi.Model.DataContext;
using SolicitudApi.Model.IoC;
using SolicitudApi.Service.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolicitudApi
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
            services.AddControllers(options => options.EnableEndpointRouting = false)
                .ConfigFluentValidation();
            services.AddDbContext<SolicitudDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddSwagger();

            services.configAutoMapper();

            services.AddModelRegistry();
            services.AddServiceRegistry();

            services.AddCors(options =>
            {
                options.AddPolicy("MainPolicy",
                      builder =>
                      {
                          builder
                                 .AllowAnyHeader()
                                 .AllowAnyMethod()
                                 .AllowCredentials();

                          //TODO: remove this line for production
                          builder.SetIsOriginAllowed(x => true);
                      });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAppSwagger();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors("MainPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
