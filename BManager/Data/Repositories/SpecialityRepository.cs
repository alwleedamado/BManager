using BManager.Utils;

namespace BManager.Data.Repositories
{
    public class SpecialityRepository : Repository<Speciality, SpecialityFilter>, ISpecialityRepository
    {

        public SpecialityRepository(BManagerDbContext context) : base(context)
        {

        }
        public override IQueryable<Speciality> Filter(IQueryable<Speciality> query, SpecialityFilter filter)
        {
            return query.AsQueryable();
        }
    }
}
