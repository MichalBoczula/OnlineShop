using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Application.Interfaces;
using OnlineShop.Application.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OnlineShop.Application
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddTransient<IMobileService, MobileService>();
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}
