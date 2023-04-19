using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Persons.Commands
{
    public class UpdatePersonCommand
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<UpdateTelephoneCommand> Telephones { get; set; }
    }
}
