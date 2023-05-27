using BManager.Infrastructure.Data.IRepositories;
using BManager.Projects.Commands;
using BManager.Projects.Queries;

namespace BManager.Projects
{
    public class ProjectController : TypedController<Project, CreateProjectCommand, UpdateProjectCommand, GetProjectQuery, ProjectFilter>
    {
        public ProjectController(IProjectRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
