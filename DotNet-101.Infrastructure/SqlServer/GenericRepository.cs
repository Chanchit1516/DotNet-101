using DotNet_101.Core.Interfaces.Repository;
using DotNet_101.Infrastructure.Data;
using DotNet_101.SharedKernel.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_101.Infrastructure.SqlServer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;
        //public readonly ILogger _logger;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<bool> Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            return true;
        }

        public bool Update(T entity)
        {
            _context.Set<T>().Update(entity);
            return true;
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await GetById(id);
            _context.Set<T>().Remove(entity);
            return true;
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().Where(predicate).ToListAsync();
        }

    }
}
