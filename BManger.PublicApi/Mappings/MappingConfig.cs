using BManager.Application.Entities;
using BManager.Application.Entities.FreelancerAggregate;
using BManager.Application.Entities.TeamAggregate;
using BManager.PublicApi.Dtos;
using BManager.PublicApi.Dtos.SpecialityType;
using BManager.PublicApi.Features.FreelancerFeature.Commands;
using BManager.PublicApi.Features.SpecialityTypeFeature;
using BManager.PublicApi.Features.TeamFeature.Commands;
using BManager.PublicApi.Features.TeamFeature.Queries;
using BManger.PublicApi.Features.FreelancerFeature.Commands;

namespace BManager.PublicApi.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Freelancer, GetFreelancerDto>()
                .ForMember(dest => dest.Specialities, opt => opt
                .MapFrom(src => src.Specialities.Select(s => new LookUpEntity(s.Id, s.SpecialityType.Name))));
            CreateMap<UpdateFreelancerCommand, Freelancer>();
            CreateMap<CreateFreelancerCommand, Freelancer>();

            CreateMap<Speciality, LookUpEntity>();

            CreateMap<Telephone, GetTelephoneDto>();
            CreateMap<AddTelephoneToFreelancerCommand, Telephone>();

            CreateMap<CreateSpecialityTypeDto, CreateSpecialityTypeCommand>();
            CreateMap<SpecialityType, GetSpecialityTypeDto>();

            CreateMap<Team, GetTeamQuery>();
            CreateMap<CreateTeamCommand, Team>();
            CreateMap<AddMemberToTeamCommand, TeamMember>();

                 }
    }
}
