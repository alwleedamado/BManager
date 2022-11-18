using BManager.Commands.Team;
using BManager.Dtos.Team;
using BManager.Queries.Team;
using BManager.Utils.Abstractions;

namespace BManager.Controllers;

public class TeamController : TypedController<Team, CreateTeamCommand, GetTeamQuery,UpdateTeamCommand, TeamFilter>
{
    public TeamController(ITeamRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }
}