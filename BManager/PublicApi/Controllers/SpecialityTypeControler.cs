using BManager.Infrastructure.Data.IRepositories;
using BManager.PublicApi.Dtos.Filters;
using BManager.PublicApi.Dtos.SpecialityType;

namespace BManager.PublicApi.Controllers
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
