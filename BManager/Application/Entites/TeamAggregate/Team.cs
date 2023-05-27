using BManager.Application.Exceptions;
using BManager.Utils.Abstractions;

namespace BManager.Application.Entites.TeamAggregate
{
    public class Team : AuditEntity
    {
        public string Name { get; set; }
        public List<TeamMember> Members { get; set; } = new List<TeamMember>();

        private Team() { }
        public Team(string name)
        {
            Name = name;
        }

        public void Addmember(TeamMember member)
        {
            if (Members.Any(m => m.Id == member.Id))
            {
                throw new MemberAccessException();
            }
            Members.Add(member);
        }

        public void RemoveMember(string memberId)
        {
            var member = Members.FirstOrDefault(m => m.Id.Equals(memberId));
            if (member != null)
            {
                throw new TeamMemberNotFoundException();
            }
            Members.Remove(member);
        }
    }
}
