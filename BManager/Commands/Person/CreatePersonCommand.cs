
using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Commands.Person
{
    public class CreatePersonCommand
    {
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public List<AddTelephoneCommand> Telephones { get; set; }
        public List<AddSpecialityCommand> Specialities { get; set; }
    }
}
