using BManager.Application.Entites.TeamAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Teams.Commands;
using Microsoft.EntityFrameworkCore;

namespace BManager.Infrastructure.Data.Repositories
{
    public class TeamRepository : Repository<Team, TeamFilter>, ITeamRepository
    {
        public TeamRepository(BManagerDbContext context) : base(context)
        {
        }

        protected override IQueryable<Team> Query => base.Query.Include(x => x.Members);
        private IQueryable<Team> QueryWithMembers => Query.Include(x => x.Members);

        public async Task<TeamMember> AddMember(Guid teamId, AddMemberToTeamCommand member)
        {
            var team = await _context.Set<Team>().FirstOrDefaultAsync(x => x.Id == teamId);
            if (team == null)
                throw new Exception("Team not found");
            return null;
        }

        public override IQueryable<Team> Filter(IQueryable<Team> query, TeamFilter filter)
        {
            return query.AsQueryable();
        }

    }
}
