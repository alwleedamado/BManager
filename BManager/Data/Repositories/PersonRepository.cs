using BManager.Data.IRepositories;
using BManager.Models;
using BManager.Queries.Person;
using BManager.Utils;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BManager.Data.Repositories
{
    public class PersonRepository : Repository<Person, PersonFilter>, IPersonRepository
    {
        protected override IQueryable<Person> Query => base.Query.Include(p => p.Telephones).Include(p => p.Specialities);
        public PersonRepository(BManagerDbContext context) : base(context)
        {

        }

        public override IQueryable<Person> Filter(IQueryable<Person> query, PersonFilter filter)
        {
            return query.OrderByDescending(x => x.Id).Include(p => p.Telephones)
                .Include(p => p.Specialities).ThenInclude(sp => sp.SpecialityType);
        }
        public override async Task<Person> GetAsync(int id)
        {
            var entity = await _context.Persons.Include(p => p.Telephones)
                .Include(p => p.Specialities)
                .ThenInclude(sp => sp.SpecialityType)
                .FirstOrDefaultAsync(x => x.Id == id && x.DeletedOn == null);
            return entity;
        }
        public override async Task<Person> GetNoTracking(int id)
        {
            var entity = await _context.Persons.Include(p => p.Telephones)
                            .Include(p => p.Specialities)
                            .ThenInclude(sp => sp.SpecialityType).AsNoTracking()
                            .FirstOrDefaultAsync(x => x.Id == id && x.DeletedOn == null);
            return entity;
        }
        public override async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context
                .Persons.AsNoTracking()
                .Include(p => p.Telephones)
                .Include(p => p.Specialities)
                .ThenInclude(sp => sp.SpecialityType)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
