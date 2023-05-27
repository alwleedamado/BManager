using BManager.Application.Entites.TeamAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Teams.Commands;
using BManager.Teams.Queries;

namespace BManager.Teams;
[ApiController]
[Route("teams")]
public class TeamController : TypedController<Team, CreateTeamCommand, GetTeamQuery, UpdateTeamCommand, TeamFilter>
{
    public TeamController(ITeamRepository repository, IMapper mapper) : base(repository, mapper)
    {
    }

    [HttpPost("{teamId:guid}")]
    public async Task<IActionResult> AddMember(Guid teamId, [FromBody] AddMemberToTeamCommand member)
    {
        /*        var result = await _repository.AddMemberAsync(teamId, member);
        */
        return null;
    }
}