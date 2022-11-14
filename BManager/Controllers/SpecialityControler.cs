using BManager.Dtos.Speciality;
using BManager.Utils.Abstractions;

namespace BManager.Controllers
{
    [Route("Specialities")]
    [ApiController]
    public class SpecialityControler : TypedController<Speciality, SpecialityCreateDto, SpecialityGetDto, SpecialityUpdateDto, SpecialityFilter>
    {
        public SpecialityControler(ISpecialityRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
