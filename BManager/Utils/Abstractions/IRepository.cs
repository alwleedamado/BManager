﻿namespace BManager.Utils.Abstractions
{
    public interface IRepository<TType, TFilterType> where TType : Entity
        where TFilterType : class
    {
        Task AddAsync(TType entity);
        Task AddAllAsync(IEnumerable<TType> entities);
        Task<QueryResult<TType>> GetByFilter(QueryParams<TFilterType> queryParams);
        IQueryable<TType> Filter(IQueryable<TType> query, TFilterType filter);
        Task<TType> GetAsync(int id);
        Task<TType> GetNoTracking(int id);
        Task<IEnumerable<TType>> GetAllAsync();
        Task<IEnumerable<TType>> GetByIds(IEnumerable<int> ids);
        Task UpdateAsync(TType entity);
        Task UpdateRange(IEnumerable<TType> entities);
        Task Delete(TType entity);
        Task Remove(TType entity);
        Task RemoveRange(IEnumerable<TType> entities);
        Task<int> CountAsync();
        Task SaveAsync();
    }
}
