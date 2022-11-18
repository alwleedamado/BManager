using System.ComponentModel.DataAnnotations;
using BManager.Utils.Abstractions;

namespace BManager.Models
{
    public class Team : AuditEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        public List<TeamMember> Members { get; set; } = new List<TeamMember>();
    }
}
