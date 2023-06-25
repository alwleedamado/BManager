using Ardalis.Specification;

namespace BManager.Infrastructure.Data
{
    public interface IRepository<T> : IRepositoryBase<T> where T : class
    {
    }
}
