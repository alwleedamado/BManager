using BManager.Application.Entities.FreelancerAggregate;
using BManager.Infrastructure.Data;
using BManager.PublicApi.Dtos;
using BManager.PublicApi.Features.SpecialityTypeFeature;
using MediatR;

namespace BManager.PublicApi.Controllers
{
    [Route("SpecialityTypes")]
    [ApiController]
    public class SpecialityTypeController :  Controller
    {
        private readonly IRepository<SpecialityType> _repository;
        private readonly IMediator _mediator;

        public SpecialityTypeController(IRepository<SpecialityType> repository, IMediator mediator)
        {
            _repository = repository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _repository.ListAsync();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] SpecialityTypeDto dto)
        {
            var result = await _mediator.Send(new CreateSpecialityTypeCommand(dto.Name, dto.Description));
            return Ok(result);
        }
        
    }
}
