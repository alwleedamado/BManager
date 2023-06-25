using BManager.Application.Entities.FreelancerAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using MediatR;

namespace BManager.PublicApi.Features.FreelancerFeature.Queries;

public class GetAllFreelancersQuery: IRequest<List<FreelancerDTO>>
{
    
}

public class GetAllFreelancerHandler : IRequestHandler<GetAllFreelancersQuery, List<FreelancerDTO>>
{
    private readonly IRepository<Freelancer> _repository;
    private readonly IMapper _mapper;

    public GetAllFreelancerHandler(IRepository<Freelancer> repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<List<FreelancerDTO>> Handle(GetAllFreelancersQuery request, CancellationToken cancellationToken)
    {
        var result = await _repository.ListAsync(cancellationToken);
        return _mapper.Map<List<FreelancerDTO>>(result);
    }
}