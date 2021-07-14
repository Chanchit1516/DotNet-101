using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Core.Services
{
    public class ProductService : IProductService
    {
        private IUnitOfWork _uow;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return await _uow.ProductRepository.GetAllProduct();
        }

    }
}
