using BManager.Application.Entities.TeamAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using MediatR;

namespace BManager.PublicApi.Features.TeamFeature.Commands;

public class CreateTeamCommand: IRequest<TeamDto>
{
    public CreateTeamCommand(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
}

public class CreateTeamHandler: IRequestHandler<CreateTeamCommand, TeamDto>
{
    private readonly IRepository<Team> _repository;

    public CreateTeamHandler(IRepository<Team> repository)
    {
        _repository = repository;
    }
    public async Task<TeamDto> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
    {
        var team = new Team(request.Name);
        await _repository.AddAsync(team, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        return new TeamDto(team.Id, team.Name);
    }
}