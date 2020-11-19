using Microsoft.Extensions.DependencyInjection;
using System;
using MediatR;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;

namespace OX.Application
{
    public static class DependancyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            try
            {
                services.AddAutoMapper(Assembly.GetExecutingAssembly());
                services.AddMediatR(Assembly.GetExecutingAssembly());

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return services;
        }

    }
}
