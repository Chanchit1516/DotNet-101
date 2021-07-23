using AutoMapper;
using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Core.Interfaces.Service;
using DotNet_101.SharedKernel.Helpers;
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
            try
            {
                var productModel = await _uow.ProductRepository.GetAllProduct();
                return _mapper.Map<IEnumerable<ProductDTO>>(productModel);
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }

        public async Task<bool> InsertProduct(ProductDTO productDTO)
        {
            try
            {
                productDTO.Barcode = Guid.NewGuid().ToString();
                var product = _mapper.Map<Product>(productDTO);
                var res = await _uow.ProductRepository.Add(product);
                await _uow.CompleteAsync();
                return res;
            }
            catch (Exception ex)
            {
                throw new AppException(ex.Message);
            }
        }

    }
}
