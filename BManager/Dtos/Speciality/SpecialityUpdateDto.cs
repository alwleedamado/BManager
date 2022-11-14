using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.Speciality
{
    public class SpecialityUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
