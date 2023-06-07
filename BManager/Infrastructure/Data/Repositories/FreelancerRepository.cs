using BManager.Application.Entites.FreelancerAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Persons.Queries;
using BManager.PublicApi.Dtos;
using Microsoft.EntityFrameworkCore;

namespace BManager.Infrastructure.Data.Repositories
{
    public class FreelancerRepository : Repository<Freelancer, FreelancerFilter>, IFreelancerRepository
    {
        protected override IQueryable<Freelancer> Query => base.Query.Include(p => p.Telephones).Include(p => p.Specialities);
        public FreelancerRepository(BManagerDbContext context) : base(context)
        {

        }

        public override IQueryable<Freelancer> Filter(IQueryable<Freelancer> query, FreelancerFilter filter)
        {
            return query.OrderByDescending(x => x.Id).Include(p => p.Telephones)
                .Include(x => x.Specialities)
                .ThenInclude(sp => sp.SpecialityType);
        }
        public override async Task<Freelancer> GetAsync(Guid id)
        {
            var entity = await _context.Freelancers.Include(p => p.Telephones)
                .Include(p => p.Specialities)
                .ThenInclude(sp => sp.SpecialityType)
                .FirstOrDefaultAsync(x => x.Id == id && x.DeletedOn == null);
            return entity;
        }
        public override async Task<Freelancer> GetNoTracking(Guid id)
        {
            var entity = await _context.Freelancers.Include(p => p.Telephones)
                            .Include(p => p.Specialities)
                            .ThenInclude(sp => sp.SpecialityType).AsNoTracking()
                            .FirstOrDefaultAsync(x => x.Id == id && x.DeletedOn == null);
            return entity;
        }
        public override async Task<IEnumerable<Freelancer>> GetAllAsync()
        {
            return await _context
                .Freelancers.AsNoTracking()
                .Include(p => p.Telephones)
                .Include(p => p.Specialities)
                .ThenInclude(sp => sp.SpecialityType)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public  async Task<List<LookUpEntity>> TypeaheadBySpecialityType(Guid specialityTypeId, string query)
        {
            return await _context.Freelancers.AsNoTracking()
                .Include(p => p.Specialities)
                .Where(x => x.Specialities.Any(sp => sp.SpecialityTypeId == specialityTypeId))
                .Where(p => p.Name.Contains(query))
                .OrderBy(p => p.Name)
                .Select(x => new LookUpEntity { Id = x.Id, Name = x.Name})
                .ToListAsync();
        }
    }
}
