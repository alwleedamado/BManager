using BManager.Projects.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface IProjectRepository : IRepository<Project, ProjectFilter>
    {
    }
}
