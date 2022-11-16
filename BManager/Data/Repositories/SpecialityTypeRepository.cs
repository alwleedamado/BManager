using BManager.Utils;

namespace BManager.Data.Repositories
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
