using BManager.Application.Entites.FreelancerAggregate;
using BManager.Utils.Abstractions;

namespace BManager.Application.Entites.TeamAggregate
{
    public class TeamMember : AuditEntity
    {
        public Guid TeamId { get; set; }
        public Team Team { get; set; }
        public Guid FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public SpecialityType SpecialityType { get; set; }
        public decimal Salary { get; set; }
    }
}
