using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Infrastructure.SqlServer;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNet_101.Infrastructure.IoC
{
    public static class ServiceModuleExtentions
    {
        public static void RegisterInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
            serviceCollection.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
