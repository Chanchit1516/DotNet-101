using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DotNet_101.Core.Entities;
using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DotNet_101.Infrastructure.SqlServer
{
    public class CustomerRepository : GenericRepository<Customer> , ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Customer>> GetAllCustomer()
        {
            try
            {
                return await _context.Customers.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}