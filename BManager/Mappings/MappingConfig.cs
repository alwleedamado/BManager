using BManager.Dtos.Person;
using BManager.Migrations;

namespace BManager.Mappings
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<PersonForCreationDto, Person>();
            CreateMap<Person, PersonGetDto>();
        }
    }
}
