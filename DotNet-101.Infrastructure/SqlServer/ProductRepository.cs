﻿using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Infrastructure.Data;
using DotNet_101.SharedKernel.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Infrastructure.SqlServer
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Product>> GetAllProduct()
        {
            try
            {
                //throw new AppException("Product not found");
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
