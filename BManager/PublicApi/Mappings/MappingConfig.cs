using BManager.Application.Entites.FreelancerAggregate;
using BManager.Application.Entites.TeamAggregate;
using BManager.Persons.Commands;
using BManager.Persons.Queries;
using BManager.PublicApi.Dtos.SpecialityType;
using BManager.Teams.Commands;
using BManager.Teams.Queries;

namespace BManager.PublicApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Freelancer, GetFreelancerQuery>()
                .ForMember(dest => dest.Specialities, opt => opt
                .MapFrom(src => src.Specialities.Select(s => new GetSpecialityQuery { Name = s.SpecialityType.Name })));
            CreateMap<UpdateFreelancerCommand, Freelancer>();
            CreateMap<CreateFreelancerCommand, Freelancer>();

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
            CreateMap<AddMemberToTeamCommand, TeamMember>();

                 }
    }
}
