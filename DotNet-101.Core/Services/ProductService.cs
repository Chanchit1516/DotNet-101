using AutoMapper;
using DotNet_101.Core.DTOs;
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
        private readonly IMapper _mapper;
        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _uow = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetAllProduct()
        {
            var productModel = await _uow.ProductRepository.GetAllProduct();
            return _mapper.Map<IEnumerable<ProductDTO>>(productModel);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAllCustomer()
        {
            var customerModel = await _uow.CustomerRepository.GetAllCustomer();
            return _mapper.Map<IEnumerable<CustomerDTO>>(customerModel);
        }

    }
}
