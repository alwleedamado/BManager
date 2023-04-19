
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using BManager.Persons.Commands;
using BManager.Persons.Queries;

namespace BManager.Persons
{
    [Route("Persons")]
    [ApiController]
    public class PersonController : TypedController<Person, CreatePersonCommand, GetPersonQuery, UpdatePersonCommand, PersonFilter>
    {
        public PersonController(IPersonRepository personRepository, IMapper mapper) : base(personRepository, mapper)
        {
        }

        [HttpPost("{personId}/specialities")]
        public async Task<ActionResult> AddSpeciality(Guid personId, [FromBody] AddSpecialityCommand speciality)
        {
            var person = await _repository.GetAsync(personId);
            if (person == null)
                return NotFound();
            person.Specialities.Add(new Speciality
            {
                SpecialityTypeId = speciality.SpecialityTypeId,
            });
            await _repository.UpdateAsync(person);
            await _repository.SaveAsync();
            return Ok(person);
        }

        [HttpDelete("{personId}/specialities/{specialityId}")]
        public async Task<ActionResult> RemoveSpeciality(Guid personId, Guid specialityId)
        {
            var person = await _repository.GetAsync(personId);
            if (person == null) return NotFound();
            var spIndex = person.Specialities.FindIndex(x => x.Id.Equals(specialityId));
            person.Specialities.RemoveAt(spIndex);
            await _repository.UpdateAsync(person);
            await _repository.SaveAsync();
            return NoContent();
        }

    }
}
