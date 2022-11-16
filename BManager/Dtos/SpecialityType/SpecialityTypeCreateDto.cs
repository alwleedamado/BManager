using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.SpecialityType
{
    public class SpecialityTypeCreateDto
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(255)]
        public string Description { get; set; }
    }
}
