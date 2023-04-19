using BManager.Teams.Commands;
using BManager.Utils;
using Microsoft.EntityFrameworkCore;

namespace BManager.Data.Repositories
{
    public class TeamReapository : Repository<BManager.Models.Team, TeamFilter>, ITeamRepository
    {
        public TeamReapository(BManagerDbContext context) : base(context)
        {
        }

        protected override IQueryable<Team> Query => base.Query.Include(x => x.Members);
        private IQueryable<Team> QueryWithMembers => Query.Include(x => x.Members);
        public override IQueryable<Team> Filter(IQueryable<Team> query, TeamFilter filter)
        {
            return query.AsQueryable();
        }
    }
}
