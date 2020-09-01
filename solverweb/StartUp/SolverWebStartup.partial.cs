using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using solverweb.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace solverweb
{
    partial class SolverWebStartup
    {

        public static IServiceCollection AddSolverData(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<SolverDbContext>(builder =>
            {
                

                var connectionString = config.GetConnectionString("db");
                builder.UseSqlServer(connectionString);

                
            });

            return services;
        }
    }
}
