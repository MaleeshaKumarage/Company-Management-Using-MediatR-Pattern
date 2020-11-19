using AutoMapper.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OX.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OX.Infrastructure
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            
            services.AddTransient<INotificationService, NotificationService>();
           
            return services;
        }
    }
}
