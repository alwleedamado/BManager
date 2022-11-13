using BManager.Dtos.Speciality;
using BManager.Models;
using BManager.Utils.Enums;

namespace BManager.Dtos.Person
{
    public class PersonGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<TelephoneGetDto> Telephones { get; set; }
        public List<SpecialityGetDto> Specialities{ get; set; }
    }
}
