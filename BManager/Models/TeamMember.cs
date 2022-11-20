using BManager.Utils.Abstractions;

namespace BManager.Models
{
    public class TeamMember : AuditEntity
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public MemberRole memberRole { get; set; }
    }
}
