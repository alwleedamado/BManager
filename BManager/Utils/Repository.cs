using BManager.Data;
using BManager.Utils.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace BManager.Utils
{
    public abstract class Repository<TType, TFilterType> : IRepository<TType, TFilterType> where TType : AuditEntity
        where TFilterType : class
    {
        protected readonly BManagerDbContext _context;
        public Repository(BManagerDbContext context)
        {
            _context = context;
        }
        protected virtual IQueryable<TType> Query => _context.Set<TType>().Where(x => x.DeletedOn == null).AsQueryable<TType>();
        public virtual async Task AddAllAsync(IEnumerable<TType> entities)
        {
            foreach (var entity in entities)
                entity.CreatedOn = DateTime.Now;
            await _context.Set<TType>().AddRangeAsync(entities).ConfigureAwait(false);
        }

        public abstract IQueryable<TType> Filter(IQueryable<TType> query, TFilterType filter);

        public virtual async Task AddAsync(TType entity)
        {
            entity.CreatedOn = DateTime.Now;
            await _context.Set<TType>().AddAsync(entity).ConfigureAwait(false);
        }

        public virtual async Task<int> CountAsync()
        {
            return await Query.CountAsync().ConfigureAwait(false);
        }
        public virtual async Task Delete(TType entity)
        {
            _context.Set<TType>().Remove(entity);
            await Task.CompletedTask;
        }

        public virtual async Task<IEnumerable<TType>> GetAllAsync()
        {
            return await Query
                .AsNoTracking()
              .OrderByDescending(x => x.Id)
              .ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<TType> GetAsync(int id)
        {
            return await _context.Set<TType>().FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task<QueryResult<TType>> GetByFilter(QueryParams<TFilterType> queryParams)
        {
            var filterd = Filter(Query.AsNoTracking(), queryParams.EntityFilters);
            filterd = queryParams.SortOrder == "asc" ? filterd.OrderBy(x => x.Id) : filterd.OrderByDescending(x => x.Id);
            filterd = filterd
                .Skip((queryParams.PageNumber - 1) * queryParams.PageSize)
                .Take(queryParams.PageSize);
            var list = await filterd.ToListAsync();
            return new QueryResult<TType>
            {
                Items = list,
                TotalCount = await filterd.CountAsync()
            };

        }

        public virtual async Task<IEnumerable<TType>> GetByIds(IEnumerable<int> ids)
        {
            return await Query
                .Where(x => ids.Contains(x.Id))
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public virtual async Task<TType> GetNoTracking(int id)
        {
            return await Query
                .AsNoTracking().FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public virtual async Task Remove(TType entity)
        {
            entity.DeletedOn = DateTime.Now;
            await UpdateAsync(entity);
        }

        public virtual async Task RemoveRange(IEnumerable<TType> entities)
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


        public virtual async Task UpdateAsync(TType entity)
        {
            entity.UpdatedOn = DateTime.Now;
            _context.Update(entity);
            await Task.CompletedTask;
        }

        public virtual async Task UpdateRange(IEnumerable<TType> entities)
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
