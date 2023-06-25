using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;

namespace BManager.Infrastructure.Data
{
    internal class BmRepository<T> : RepositoryBase<T>, IReadRepositoryBase<T>, IRepository<T> where T : class
    {
        public BmRepository(BManagerDbContext dbContext) : base(dbContext) { }
    }
}
