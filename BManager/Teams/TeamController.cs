using BManager.Application.Entites.TeamAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Teams.Commands;
using BManager.Teams.Queries;

namespace BManager.Teams;
[ApiController]
[Route("teams")]
public class TeamController : TypedController<Team, CreateTeamCommand, GetTeamQuery, UpdateTeamCommand, TeamFilter>
{
    private readonly ITeamRepository _teamRepository;
    public TeamController(ITeamRepository repository, IMapper mapper) : base(repository, mapper)
    {
        _teamRepository = repository;
    }

    [HttpPost("{teamId:guid}/AddMember")]
    public async Task<IActionResult> AddMember(Guid teamId, [FromBody] AddMemberToTeamCommand member)
    {
        await _teamRepository.AddMember(teamId, _mapper.Map<TeamMember>(member));
        await _teamRepository.SaveAsync();
        return NoContent();
    }

    [HttpGet("{teamid:guid}/GetMembers")]
    public async Task<IActionResult> GetTeammembers(Guid teamId)
    {
        var entities = await _teamRepository.GetMembers(teamId);
        return Ok(entities);
    }
}