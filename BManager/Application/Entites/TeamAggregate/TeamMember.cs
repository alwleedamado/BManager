using BManager.Utils.Abstractions;

namespace BManager.Application.Entites.TeamAggregate
{
    public class TeamMember : AuditEntity
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int FreelancerId { get; set; }
        public Freelancer Freelancer { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public SpecialityType SpecialityType { get; set; }
        public decimal Salary { get; set; }
    }
}
