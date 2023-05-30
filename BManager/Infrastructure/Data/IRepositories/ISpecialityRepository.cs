using BManager.Application.Entites.FreelancerAggregate;
using BManager.PublicApi.Dtos.Filters;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface ISpecialityRepository : IRepository<Speciality, SpecialityFilter>
    {
    }
}
