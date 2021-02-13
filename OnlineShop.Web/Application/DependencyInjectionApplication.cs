using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OnlineShop.Web.Application.Interfaces;
using OnlineShop.Web.Application.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OnlineShop.Web.Application
{
    public static class DependencyInjectionApplication
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddTransient<IMobilePhoneService, MobilePhoneService>();
            service.AddAutoMapper(Assembly.GetExecutingAssembly());
            return service;
        }
    }
}
