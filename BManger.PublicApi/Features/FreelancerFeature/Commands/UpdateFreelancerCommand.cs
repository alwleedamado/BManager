using Ardalis.GuardClauses;
using Ardalis.Result;
using BManager.Application.Entities.FreelancerAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using MediatR;

namespace BManager.PublicApi.Features.FreelancerFeature.Commands;

public class UpdateFreelancerCommand : IRequest<GetFreelancerDto>
{
    public UpdateFreelancerCommand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    
}

public class UpdateFreelancerHandler : IRequestHandler<UpdateFreelancerCommand, GetFreelancerDto>
{
    private readonly IRepository<Freelancer> _repository;
    private readonly IMapper _mapper;

    public UpdateFreelancerHandler(IRepository<Freelancer> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<GetFreelancerDto> Handle(UpdateFreelancerCommand request, CancellationToken cancellationToken)
    {
        var freelancer = await _repository.GetByIdAsync(request.Id, cancellationToken);
        if (freelancer == null)
            throw new NotFoundException("Id", "Freelancer");
        freelancer.Name = request.Name;
        await _repository.UpdateAsync(freelancer, cancellationToken);
        await _repository.SaveChangesAsync(cancellationToken);
        return _mapper.Map<GetFreelancerDto>(freelancer);
    }
}