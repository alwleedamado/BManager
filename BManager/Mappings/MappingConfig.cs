using BManager.Commands.Person;

using BManager.Dtos.SpecialityType;
using BManager.Models;
using BManager.Queries.Person;

namespace BManager.Mappings
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, GetPersonQuery>()
                .ForMember(dest => dest.Specialities, opt => opt
                .MapFrom(src => src.Specialities.Select(s => new GetSpecialityQuery { Name = s.SpecialityType.Name })));
            CreateMap<UpdatePersonCommand, Person>();
            CreateMap<CreatePersonCommand, Person>();

            CreateMap<Telephone, GetTelephoneQuery>();
            CreateMap<AddTelephoneCommand, Telephone>();
            CreateMap<UpdateTelephoneCommand, Telephone>();

            CreateMap<SpecialityTypeCreateDto, SpecialityType>();
            CreateMap<SpecialityType, SpecialityTypeGetDto>();
            CreateMap<SpecialityTypeUpdateDto, SpecialityType>();
            CreateMap<SpecialityType, SpecialityTypeGetDto>();
        }
    }
}
