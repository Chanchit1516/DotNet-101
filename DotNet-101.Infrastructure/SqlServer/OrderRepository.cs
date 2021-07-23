using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNet_101.Infrastructure.SqlServer
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<List<Order>> GetAllOrder()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}