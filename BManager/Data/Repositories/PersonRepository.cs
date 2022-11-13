using BManager.Data.IRepositories;
using BManager.Dtos.Filters;
using BManager.Models;
using BManager.Utils;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace BManager.Data.Repositories
{
    public class PersonRepository : Repository<Person, PersonFilter>, IPersonRepository
    {
        protected override IQueryable<Person> Query => base.Query.Include(p => p.Telephones);
        public PersonRepository(BManagerDbContext context) : base(context)
        {

        }

        public override IQueryable<Person> Filter(IQueryable<Person> query, PersonFilter filter)
        {
            return query.OrderByDescending(x => x.Id);
        }

        public override async Task<IEnumerable<Person>> GetAllAsync()
        {
            return await _context
                .Persons.AsNoTracking()
                .Include(p => p.Telephones)
                .ToListAsync()
                .ConfigureAwait(false);
        }

    }
}
