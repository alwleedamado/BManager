using Ardalis.GuardClauses;
using Ardalis.Result;
using BManager.Application.Entities.TeamAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using BManager.PublicApi.Features.TeamFeature.Commands;
using MediatR;

namespace BManager.PublicApi.Features.TeamFeature.Commands
{
    public class UpdateTeamCommand : IRequest<TeamDto>
    {
        public UpdateTeamCommand(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}

public class UpdateTeamHandler : IRequestHandler<UpdateTeamCommand, TeamDto>
{
    private readonly IRepository<Team> _repository;

    public UpdateTeamHandler(IRepository<Team> repository)
    {
        _repository = repository;
    }
    public async Task<TeamDto> Handle(UpdateTeamCommand request, CancellationToken cancellationToken)
    {
        var aggregateToUpdate = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (aggregateToUpdate == null)
            throw new NotFoundException(request.Id.ToString(), "Team");
        aggregateToUpdate.UpdateName(request.Name);
        return new TeamDto(request.Id, request.Name);
    }
}