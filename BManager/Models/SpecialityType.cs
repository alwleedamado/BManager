using BManager.Utils.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace BManager.Models
{
    public class SpecialityType : AuditEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(255)]
        public string Description { get; set; }
    }
}
