using AutoMapper;
using BManager.Data.IRepositories;
using BManager.Data.Repositories;
using BManager.Dtos.Person;
using BManager.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : TypedController<Person, PersonForCreationDto, PersonGetDto, PersonUpdateDto, PersonRepository>
    {
        public PersonController(IPersonRepository personRepository, IMapper mapper)
        {
            _repository = personRepository;
            _mapper = mapper;
        }

        // GET: api/<ValuesController>
      
    }
}
