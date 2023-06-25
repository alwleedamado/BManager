using Ardalis.Result;
using BManager.Application.Entities.TeamAggregate;
using BManager.Infrastructure.Data;
using MediatR;

namespace BManager.PublicApi.Features.TeamFeature.Commands;

public class AddMemberToTeamCommand: IRequest<Result>
{
    public Guid FreelancerId { get; set; }
    public Guid SpecialityTypeId { get; set; }
    public decimal Salary { get; set; }
    public Guid TeamId { get; set; }
}

public class AddMemberHandler: IRequestHandler<AddMemberToTeamCommand, Result>
{
    private readonly IRepository<Team> _repository;

    public AddMemberHandler(IRepository<Team> repository)
    {
        _repository = repository;
    }

    public async Task<Result> Handle(AddMemberToTeamCommand request, CancellationToken cancellationToken)
    {
        var team = await _repository.GetByIdAsync(request.TeamId, cancellationToken);
        if(team == null) return Result.Error("Team not found");
        team.Addmember(new TeamMember
        {
            FreelancerId = request.FreelancerId,
            SpecialityTypeId = request.SpecialityTypeId,
            Salary = request.Salary
        });
        await _repository.UpdateAsync(team, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        return Result.SuccessWithMessage("Team Member Added");
    }
}