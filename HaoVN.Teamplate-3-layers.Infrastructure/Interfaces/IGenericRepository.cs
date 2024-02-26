using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaoVN.Teamplate_3_layers.Infrastructure.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T?> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task<bool> Add(T entity);
        Task<bool> Remove(T entity);
        Task<bool> Update(T entity);
    }
}
