using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using System.Linq.Expressions;
using Villa.DataAccess.Abstracts;
using Villa.DataAccess.Context;
using Villa.Entity.Entities;

namespace Villa.DataAccess.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : BaseEntity
    {
        private readonly VillaContext _context;

        public GenericRepository(VillaContext context)
        {
            _context = context;
        }

        private DbSet<T> Table { get => _context.Set<T>(); }
        public async Task<int> CountAsync()
        {
            return await Table.CountAsync();
        }

        public async Task CreateAsync(T entity)
        {
            await Table.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ObjectId id)
        {
            var value = await GetByIdAsync(id);
            Table.Remove(value);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(ObjectId id)
        {
            return await Table.FindAsync(id);
        }

        public async Task<List<T>> GetFilteredListAsync(Expression<Func<T, bool>> predicate)
        {
            return await Table.Where(predicate).ToListAsync();
        }

        public async Task<List<T>> GetListAsync()
        {
            return await Table.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            Table.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
