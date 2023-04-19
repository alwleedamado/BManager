using BManager.Teams.Commands;
using BManager.Teams.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Teams;

public class TeamController : TypedController<Team, CreateTeamCommand, GetTeamQuery, UpdateTeamCommand, TeamFilter>
{
    public TeamController(ITeamRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}