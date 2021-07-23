using DotNet_101.Core.Interfaces.Service;
using DotNet_101.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Core.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterCoreServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IProductService, ProductService>();
            serviceCollection.AddScoped<ICustomerService, CustomerService>();
            serviceCollection.AddScoped<IOrderService, OrderService>();
        }
    }
}
