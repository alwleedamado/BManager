using BManager.Application.Entites.TeamAggregate;
using BManager.Teams.Commands;
using BManager.Teams.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface ITeamRepository : IRepository<Team, TeamFilter>
    {
        Task AddMember(Guid teamId, TeamMember member);
        Task<List<TeamMemberQuery>> GetMembers(Guid teamId);
    }
}
