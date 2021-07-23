using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_101.Core.DTOs;

namespace DotNet_101.Core.Interfaces.Service
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetAllOrder();
        Task<bool> InsertOrder(OrderDTO order);
    }
}