using BManager.Projects.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Data.IRepositories
{
    public interface IProjectRepository : IRepository<Project, ProjectFilter>
    {
    }
}
