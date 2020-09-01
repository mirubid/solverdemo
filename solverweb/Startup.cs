using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Routing;
using Microsoft.OData.Edm;
using Microsoft.AspNet.OData.Builder;
using solverweb.Controllers;

namespace solverweb
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            Environment = env;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddOData();
            //services.AddODataQueryFilter();

            services.AddSolverData(Configuration);
                
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
                
                endpoints.Select().Filter().OrderBy().Count().MaxTop(25);

                endpoints.MapODataRoute("odata", "odata", GetEdmModel());

            });

            
        }
        public IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();

            SolverWebStartup.ConfigureOdata(odataBuilder);

            var demo = odataBuilder.EntitySet<City>("Test");
            demo.EntityType.HasKey(e => new { e.CityID });

            return odataBuilder.GetEdmModel();
            
        }
    }
}
