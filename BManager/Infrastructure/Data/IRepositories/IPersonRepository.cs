using BManager.Application.Entites.FreelancerAggregate;
using BManager.Persons.Queries;
using BManager.Utils.Abstractions;

namespace BManager.Infrastructure.Data.IRepositories
{
    public interface IFreelancerRepository : IRepository<Freelancer, FreelancerFilter>
    {
    }
}
