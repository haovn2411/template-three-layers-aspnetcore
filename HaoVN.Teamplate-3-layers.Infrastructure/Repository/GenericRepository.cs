using HaoVN.Teamplate_3_layers.Infrastructure.Data;
using HaoVN.Teamplate_3_layers.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected StudentContext _context;
        protected DbSet<T> dbSet;
        protected readonly ILogger _logger;
        public GenericRepository(
            StudentContext context,
            ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = _context.Set<T>();
        }

        public async Task<bool> Add(T entity)
        {
            await dbSet.AddAsync(entity);
            return true;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return dbSet.Where(expression);
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await dbSet.FindAsync(id);
        }


        public async Task<bool> Remove(T entity)
        {
            if (entity != null)
            {
                dbSet.Remove(entity);
                return true;
            }
            else
                return false;
        }

        public Task<bool> Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            return Task.FromResult(true);
        }
    }
}
