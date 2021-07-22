using DotNet_101.Core.DTOs;
using DotNet_101.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Core.Interfaces.Service
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDTO>> GetAllProduct();
        Task<IEnumerable<CustomerDTO>> GetAllCustomer();
    }
}
