using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Villa.Business.Abstracts
{
    public interface IGenericService<T> where T : BaseEntity
    {
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(ObjectId id);

        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(ObjectId id);
        Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> predicate);

        Task<int> TCountAsync();
    }
}
