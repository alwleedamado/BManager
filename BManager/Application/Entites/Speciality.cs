using BManager.Utils.Abstractions;

namespace BManager.Application.Entites
{
    public class Speciality : AuditEntity
    {
        public SpecialityType SpecialityType { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public Guid FreelancerId { get; set; }
        public Guid Freelancer { get; set; }
    }
}
