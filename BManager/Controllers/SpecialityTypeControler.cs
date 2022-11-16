using BManager.Dtos.SpecialityType;
using BManager.Utils.Abstractions;

namespace BManager.Controllers
{
    [Route("SpecialityTypes")]
    [ApiController]
    public class SpecialityTypeControler : TypedController<SpecialityType, SpecialityTypeCreateDto, SpecialityTypeGetDto, SpecialityTypeUpdateDto, SpecialityTypeFilter>
    {
        public SpecialityTypeControler(ISpecialityTypeRepository repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
