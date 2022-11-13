using BManager.Dtos.Speciality;
using BManager.Dtos.Telephone;
using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.Person
{
    public class PersonForCreationDto
    {
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public List<TelephoneCreateDto> Telephones { get; set; }
        public List<SpecialityCreateDto> Specialities{ get; set; }
    }
}
