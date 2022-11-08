namespace BManager.Utils.Abstractions
{
    public interface IRepository<T> where T : Entity
    {
        Task AddAsync(T entity);
        Task AddAllAsync(IEnumerable<T> entities);
        Task<T> GetAsync(int id);
        Task<T> GetNoTracking(int id);
        Task<IEnumerable<T>> GetAllAsync(QueryParams query);
        Task<IEnumerable<T>> GetByIds(IEnumerable<int> ids);
        Task UpdateAsync(T entity);
        Task UpdateRange(IEnumerable<T> entities);
        Task Delete(T entity);
        Task Remove(T entity);
        Task RemoveRange(IEnumerable<T> entities);
        Task<int> CountAsync();
        Task SaveAsync();
    }
}
