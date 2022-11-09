using BManager.Data.IRepositories;
using BManager.Models;
using BManager.Utils;
using Microsoft.EntityFrameworkCore;

namespace BManager.Data.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(BManagerDbContext context) : base(context)
        {

        }

        public override async Task<IEnumerable<Person>> GetAllAsync(QueryParams query)
        {
            return await _context
                .Persons.AsNoTracking()
                .Include(p => p.Telephones)
                .ToListAsync()
                .ConfigureAwait(false);
        }
    }
}
