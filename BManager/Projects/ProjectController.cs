using BManager.Projects.Commands;
using BManager.Projects.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Projects
{
    public class ProjectController : TypedController<BManager.Models.Project, CreateProjectCommand, UpdateProjectCommand, GetProjectQuery, ProjectFilter>
    {
        public ProjectController(IProjectRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
