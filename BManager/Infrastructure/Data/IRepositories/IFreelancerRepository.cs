using BManager.Application.Entites.FreelancerAggregate;
using BManager.Persons.Queries;
using BManager.PublicApi.Dtos;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface IFreelancerRepository : IRepository<Freelancer, FreelancerFilter>
    {
        Task<List<LookUpEntity>> TypeaheadBySpecialityType(Guid specialityTypeId, string query);
    }
}
