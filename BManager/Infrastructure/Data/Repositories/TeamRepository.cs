using BManager.Application.Entites.TeamAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Teams.Commands;
using BManager.Teams.Queries;
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

        public async Task AddMember(Guid teamId, TeamMember member)
        {
            var team = await _context.Set<Team>().FirstOrDefaultAsync(x => x.Id == teamId);
            if (team == null)
                throw new Exception("Team not found");
            team.Addmember(member);
        }

        public override IQueryable<Team> Filter(IQueryable<Team> query, TeamFilter filter)
        {
            return query.AsQueryable();
        }

        public async Task<List<TeamMemberQuery>> GetMembers(Guid teamId)
        {
            var team =await _context.Set<Team>()
                .Include(t => t.Members)
                .ThenInclude(tm => tm.Freelancer)
                .Include(tm => tm.Members)
                .ThenInclude(tm => tm.SpecialityType)
                .FirstOrDefaultAsync(x => x.Id == teamId);
            if (team == null)
                throw new Exception("Team not found");
            var members = team.Members.Select(t => new TeamMemberQuery
            {
                Id = t.Id,
                Name = t.Freelancer.Name,
                FreelancerId = t.FreelancerId,
                Salary = t.Salary,
                SpecialityType = t.SpecialityType.Name,
                SpecialityTypeId = t.SpecialityTypeId
            });
            return members.ToList();
        }

    }
}
