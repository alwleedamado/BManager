using BManager.Dtos.Person;
using BManager.Dtos.Speciality;
using BManager.Dtos.Telephone;
using BManager.Models;

namespace BManager.Mappings
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, PersonGetDto>();
            CreateMap<PersonUpdateDto, Person>();
            CreateMap<PersonForCreationDto, Person>();

            CreateMap<Telephone, TelephoneGetDto>();
            CreateMap<TelephoneCreateDto, Telephone>();
            CreateMap<TelephoneUpdateDto, Telephone>();

            CreateMap<Speciality, SpecialityGetDto>();
            CreateMap<SpecialityCreateDto, Speciality>();
            CreateMap<SpecialityUpdateDto, Speciality>();
        }
    }
}
