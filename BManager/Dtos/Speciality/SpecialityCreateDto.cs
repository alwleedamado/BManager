using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.Speciality
{
    public class SpecialityCreateDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
