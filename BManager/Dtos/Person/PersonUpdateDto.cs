using BManager.Dtos.Speciality;
using BManager.Dtos.Telephone;
using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.Person
{
    public class PersonUpdateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<TelephoneUpdateDto> Telephones { get; set; }
        public List<SpecialityUpdateDto> Specialities { get; set; }
    }
}
