using BManager.Application.Entities.TeamAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using MediatR;

namespace BManager.PublicApi.Features.TeamFeature.Queries;

public class GetAllTeamsQuery : IRequest<List<TeamDto>>
{
    
}

public class GetAllTeamsHandler : IRequestHandler<GetAllTeamsQuery, List<TeamDto>>
{
    private readonly IRepository<Team> _repository;
    private readonly IMapper _mapper;

    public GetAllTeamsHandler(IRepository<Team> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<List<TeamDto>> Handle(GetAllTeamsQuery request, CancellationToken cancellationToken)
    {
        var result =  await _repository.ListAsync(cancellationToken);
        return _mapper.Map<List<TeamDto>>(request);
    }
}