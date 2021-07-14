using DotNet_101.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Core.Interfaces.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProduct();
    }
}
