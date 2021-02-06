using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Domain.Interfaces;
using OnlineShop.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Infrastructure
{
    public static class DependencyInjectionInfrastructure
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service)
        {
            service.AddTransient<IMobilePhoneRepository, MobilePhoneRepository>();
            return service;
        }
    }
}
