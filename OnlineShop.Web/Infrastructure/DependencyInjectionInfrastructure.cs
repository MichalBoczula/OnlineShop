using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Infrastructure.Repositories;
using OnlineShop.Web.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Web.Infrastructure
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
