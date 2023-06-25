using BManaber.Application.Entites;
using BManager.Utils.Abstractions;

namespace BManager.Application.Entites.FreelancerAggregate
{
    public class Speciality : EntityBase<int>
    {
        public SpecialityType SpecialityType { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public Guid FreelancerId { get; set; }
        public Guid Freelancer { get; set; }
    }
}
