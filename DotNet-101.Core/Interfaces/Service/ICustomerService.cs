using DotNet_101.Core.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DotNet_101.Core.Interfaces.Service
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerDTO>> GetAllCustomer();
        Task<bool> InsertCustomer(CustomerDTO product);
    }
}