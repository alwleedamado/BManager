using System.ComponentModel.DataAnnotations;

namespace BManager.Commands.Team
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
