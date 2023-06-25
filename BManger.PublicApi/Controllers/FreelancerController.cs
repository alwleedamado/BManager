
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using BManager.Application.Entities.FreelancerAggregate;
using BManager.Application.Entities.FreelancerAggregate.Specifications;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Features.FreelancerFeature.Commands;
using BManager.PublicApi.Features.FreelancerFeature.Queries;
using MediatR;

namespace BManager.PublicApi.Controllers
{
    [Route("Freelancers")]
    [ApiController]
    public class FreelancerController : Controller
    {
        private readonly IRepository<Freelancer> _freelancerRepository;
        private readonly IMediator _mediator;
        public FreelancerController(IRepository<Freelancer> freelancerRepository, IMediator mediator)
        {
            _freelancerRepository = freelancerRepository;
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllFreelancersQuery());
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateFreelancerCommand command)
        {
            await _mediator.Send(new CreateFreelancerCommand(command.Name, command.Email, command.Gender));
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _mediator.Send(new DeleteFreelancerCommand(id));
            if (result.IsSuccess) return Ok(result.SuccessMessage);
            return NotFound();
        }
        [HttpPost("{freelancerId}/specialities/{specialityTypeId:guid}")]
        public async Task<ActionResult> AddSpeciality(Guid freelancerId, [FromBody] Guid specialityTypeId)
        {
            var result = await _mediator.Send(new AddSpecialityToFreelancerCommand(freelancerId, specialityTypeId));
            if (result.IsSuccess) return Ok(result.SuccessMessage);
            return BadRequest();

        }

        [HttpDelete("{freelancerId}/specialities/{specialityTypeId:guid}")]
        public async Task<ActionResult> RemoveSpeciality(Guid freelancerId, Guid specialityTypeId)
        {

            var result =
                await _mediator.Send(new RemoveSpecialityFromFreelancerCommand(freelancerId, specialityTypeId));
            if (result.IsSuccess) return Ok(result.SuccessMessage);
            return BadRequest();
        }

        [HttpGet("typeaheadBySpecialityType/{specialityTypeId:guid}/{query}")]
        public async Task<IActionResult> TypeaheadBySpecialityType(Guid specialityTypeId, string query)
        {
            var typeaheadSpec = new FreelancerTypeaheadBySpecialitySpec(specialityTypeId, query);
            var entities = await _freelancerRepository.ListAsync(typeaheadSpec);
            return Ok(entities);
        }
    }
}
