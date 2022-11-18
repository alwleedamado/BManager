using BManager.Dtos.Team;
using BManager.Utils.Abstractions;

namespace BManager.Data.IRepositories
{
    public interface ITeamRepository : IRepository<Team,TeamFilter>
    {
        
    }
}
