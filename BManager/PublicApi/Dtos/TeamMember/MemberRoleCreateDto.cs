using System.ComponentModel.DataAnnotations;

namespace BManager.PublicApi.Dtos.TeamMember
{
    public class MemberRoleCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
