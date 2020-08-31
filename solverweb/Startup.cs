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
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddOData();
            services.AddODataQueryFilter();

                
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
                endpoints.MapODataRoute("odata", "odata", GetEdmModel());
                endpoints.Filter().MaxTop(100);
                endpoints.MapGet("{*path}", (HttpContext context)=> {
                    context.Response.ContentType = "text/plain";
                    context.Response.StatusCode = 200;
                    var path = context.Request.RouteValues["path"]??"null";
                    return context.Response.WriteAsync($"hello world ({path})");
                });
                
            });

            
        }
        public IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();

            var demo = odataBuilder.EntitySet<Demo>("Demo");
            demo.EntityType.HasKey(d => d.Key);

            return odataBuilder.GetEdmModel();

        }
    }
}
