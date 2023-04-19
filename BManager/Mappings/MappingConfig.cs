using BManager.Dtos.SpecialityType;
using BManager.Persons.Commands;
using BManager.Persons.Queries;
using BManager.Teams.Commands;
using BManager.Teams.Queries;

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

            CreateMap<Speciality, GetSpecialityQuery>();
            
            CreateMap<Telephone, GetTelephoneQuery>();
            CreateMap<AddTelephoneCommand, Telephone>();
            CreateMap<UpdateTelephoneCommand, Telephone>();

            CreateMap<SpecialityTypeCreateDto, SpecialityType>();
            CreateMap<SpecialityType, SpecialityTypeGetDto>();
            CreateMap<SpecialityTypeUpdateDto, SpecialityType>();

            CreateMap<Team, GetTeamQuery>();
            CreateMap<CreateTeamCommand, Team>();
            CreateMap<UpdateTelephoneCommand, Team>();
        }
    }
}
