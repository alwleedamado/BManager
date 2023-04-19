using System.ComponentModel.DataAnnotations;

namespace BManager.Teams.Commands
{
    public class AddMemberToTeamCommand
    {
        [Required]
        public int TeamId { get; set; }
        [Required]
        public int MemberId { get; set; }

        [Required]
        public int MemberRoleId { get; set; }
    }
}
