//using DotNet_101.Core.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.Logging;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DotNet_101.Infrastructure.Data
//{
//    public class ApplicationDbContextSeed
//    {
//        public static async Task SeedAsync(ApplicationDbContext applicationContext, ILoggerFactory loggerFactory, int? retry = 0)
//        {
//            int retryForAvailability = retry.Value;

//            try
//            {
//                // TODO: Only run this if using a real database
//                applicationContext.Database.Migrate();
//                applicationContext.Database.EnsureCreated();

//                if (!applicationContext.Orders.Any())
//                {
//                    applicationContext.Orders.AddRange(GetPreconfiguredCategories());
//                    await applicationContext.SaveChangesAsync();
//                }

//                if (!applicationContext.Products.Any())
//                {
//                    applicationContext.Products.AddRange(GetPreconfiguredProducts());
//                    await applicationContext.SaveChangesAsync();
//                }
//            }
//            catch (Exception exception)
//            {
//                if (retryForAvailability < 10)
//                {
//                    retryForAvailability++;
//                    var log = loggerFactory.CreateLogger<ApplicationDbContextSeed>();
//                    log.LogError(exception.Message);
//                    await SeedAsync(applicationContext, loggerFactory, retryForAvailability);
//                }
//                throw;
//            }
//        }

//        private static IEnumerable<Order> GetPreconfiguredCategories()
//        {
//            return new List<Order>()
//            {
//                new Order() { CustomerId = 1},
//                new Order() { CustomerId = 2}
//            };
//        }

//        private static IEnumerable<Product> GetPreconfiguredProducts()
//        {
//            return new List<Product>()
//            {
//                new Product() { ProductName = "IPhone" , UnitPrice = 19.5M , UnitsInStock = 10, UnitsOnOrder = 1 },
//                new Product() { ProductName = "Samsung" , UnitPrice = 33.5M , UnitsInStock = 10, UnitsOnOrder = 1 },
//                new Product() { ProductName = "LG TV" , UnitPrice = 33.5M , UnitsInStock = 10, UnitsOnOrder = 1}
//            };
//        }
//    }
//}
