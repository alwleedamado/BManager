
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using BManager.Application.Entites.FreelancerAggregate;
using BManager.Infrastructure.Data.IRepositories;
using BManager.Persons.Commands;
using BManager.Persons.Queries;

namespace BManager.Persons
{
    [Route("Freelancers")]
    [ApiController]
    public class FreelancerController : TypedController<Freelancer, CreateFreelancerCommand, GetFreelancerQuery, UpdateFreelancerCommand, FreelancerFilter>
    {
        public FreelancerController(IFreelancerRepository FreelancerRepository, IMapper mapper) : base(FreelancerRepository, mapper)
        {
        }

        [HttpPost("{FreelancerId}/specialities")]
        public async Task<ActionResult> AddSpeciality(Guid FreelancerId, [FromBody] AddSpecialityCommand speciality)
        {
            var Freelancer = await _repository.GetAsync(FreelancerId);
            if (Freelancer == null)
                return NotFound();
            Freelancer.AddSpeciality(speciality.SpecialityTypeId);
            await _repository.UpdateAsync(Freelancer);
            await _repository.SaveAsync();
            return Ok(Freelancer);
        }

        [HttpDelete("{FreelancerId}/specialities/{specialityId}")]
        public async Task<ActionResult> RemoveSpeciality(Guid FreelancerId, Guid specialityId)
        {
            var Freelancer = await _repository.GetAsync(FreelancerId);
            if (Freelancer == null) return NotFound();
            Freelancer.RemoveSpeciality(specialityId);
            await _repository.UpdateAsync(Freelancer);
            await _repository.SaveAsync();
            return NoContent();
        }

    }
}
