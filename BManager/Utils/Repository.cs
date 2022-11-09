using BManager.Data;
using BManager.Utils.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BManager.Utils
{
    public abstract class Repository<T> : IRepository<T> where T : AuditEntity
    {
        protected readonly BManagerDbContext _context;
        public Repository(BManagerDbContext context)
        {
            _context = context;
        }

        public virtual async Task AddAllAsync(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
                entity.CreatedOn = DateTime.Now;
            await _context.Set<T>().AddRangeAsync(entities).ConfigureAwait(false);
        }

        public virtual async Task AddAsync(T entity)
        {
            entity.CreatedOn = DateTime.Now;
            await _context.Set<T>().AddAsync(entity).ConfigureAwait(false);
        }

        public virtual async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync().ConfigureAwait(false);
        }
        public virtual async Task Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            await Task.CompletedTask;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync(QueryParams query)
        {
            var pageCount = query.PageCount != 0 ? query.PageCount : 1;
            var pageSize = query.PageSize != 0 ? query.PageSize : 10;
            return await _context.Set<T>()
                .AsNoTracking()
              .OrderByDescending(x => x.Id)
              .Skip((pageCount - 1) * query.PageSize)
              .Take(pageSize)
              .ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<T> GetAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task<IEnumerable<T>> GetByIds(IEnumerable<int> ids)
        {
            return await _context.Set<T>()
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public virtual async Task<T> GetNoTracking(int id)
        {
            return await _context.Set<T>()
                .AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public virtual async Task Remove(T entity)
        {
            entity.DeletedOn = DateTime.Now;
            await UpdateAsync(entity);
        }

        public virtual async Task RemoveRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.DeletedOn = DateTime.Now;
                await UpdateAsync(entity);
            }
        }
        public virtual async Task SaveAsync()
        {
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }


        public virtual async Task UpdateAsync(T entity)
        {
            entity.UpdatedOn = DateTime.Now;
            _context.Update(entity);
            await Task.CompletedTask;
        }

        public virtual async Task UpdateRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.UpdatedOn = DateTime.Now;
                _context.Update(entity);
            }
            await Task.CompletedTask;
        }
    }
}
