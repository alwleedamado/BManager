
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BManager.Controllers
{
    [Route("Persons")]
    [ApiController]
    public class PersonController : TypedController<Person, PersonForCreationDto, PersonGetDto, PersonUpdateDto, PersonFilter>
    {
        public PersonController(IPersonRepository personRepository, IMapper mapper) : base(personRepository, mapper)
        {
        }      
    }
}
