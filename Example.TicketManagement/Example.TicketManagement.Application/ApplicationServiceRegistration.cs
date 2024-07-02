﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.TicketManagement.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg
            .RegisterServicesFromAssemblies
                (AppDomain.CurrentDomain.GetAssemblies()));
            return services;
        }
    }
}
