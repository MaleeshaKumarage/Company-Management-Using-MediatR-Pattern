using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OX.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OX.Persistence.Data
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDBContext>(option => option.UseSqlite("Data Source=OXDatabase.db"));
            //services.AddDbContext<ApplicationDBContext>(option => option.UseSqlServer(configuration.GetConnectionString("EcomBotDBCon")));

            services.AddScoped<IApplicationDBContext>(provider => provider.GetService<ApplicationDBContext>());
            return services;
        }
    }
}
