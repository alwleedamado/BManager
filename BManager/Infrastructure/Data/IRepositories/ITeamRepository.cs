using BManager.Application.Entites.TeamAggregate;
using BManager.Teams.Commands;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface ITeamRepository : IRepository<Team, TeamFilter>
    {
        Task<TeamMember> AddMember(Guid teamId, AddMemberToTeamCommand member);
    }
}
