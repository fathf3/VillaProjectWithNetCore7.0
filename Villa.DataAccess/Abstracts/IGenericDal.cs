using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.DataAccess.Abstracts
{
    public interface IGenericDal<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(ObjectId id);

        Task<List<T>> GetListAsync();
        Task<T> GetByIdAsync(ObjectId id);
        Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> predicate);

        Task<int> CountAsync();
        
    }
}
