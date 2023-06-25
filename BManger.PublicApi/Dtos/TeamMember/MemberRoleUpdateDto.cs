using System.ComponentModel.DataAnnotations;

namespace BManager.PublicApi.Dtos.TeamMember
{
    public class MemberRoleUpdateDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
