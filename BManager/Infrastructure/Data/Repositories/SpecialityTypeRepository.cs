using BManager.Infrastructure.Data.IRepositories;
using BManager.PublicApi.Dtos.Filters;

namespace BManager.Infrastructure.Data.Repositories
{
    public class SpecialityTypeRepository : Repository<SpecialityType, SpecialityTypeFilter>, ISpecialityTypeRepository
    {

        public SpecialityTypeRepository(BManagerDbContext context) : base(context)
        {

        }
        public override IQueryable<SpecialityType> Filter(IQueryable<SpecialityType> query, SpecialityTypeFilter filter)
        {
            return query.AsQueryable();
        }
    }
}
