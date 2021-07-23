using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_101.Core.Entities;

namespace DotNet_101.Core.Interfaces.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Task<List<Order>> GetAllOrder();
    }
}