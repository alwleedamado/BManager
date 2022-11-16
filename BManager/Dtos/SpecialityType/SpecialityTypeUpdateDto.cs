using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.SpecialityType
{
    public class SpecialityTypeUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public int Name { get; set; }
        [Required, MinLength(255)]
        public string Description { get; set; }
    }
}
