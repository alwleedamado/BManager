using System.ComponentModel.DataAnnotations;

namespace BManager.Teams.Commands
{
    public class AddMemberToTeamCommand
    {
        [Required]
        public Guid TeamId { get; set; }
        [Required]
        public Guid MemberId { get; set; }

        [Required]
        public Guid MemberRoleId { get; set; }
    }
}
