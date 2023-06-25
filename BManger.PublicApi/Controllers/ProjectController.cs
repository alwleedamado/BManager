using BManager.Application.Entities;
using BManager.Infrastructure.Data;

namespace BManager.PublicApi.Features.ProjectFeature
{
    public class ProjectController : Controller
    {
        private readonly IRepository<Project> _repository;
        private readonly IMapper _mapper;

        public ProjectController(IRepository<Project> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}
