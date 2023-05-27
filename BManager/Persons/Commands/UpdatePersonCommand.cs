using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Persons.Commands
{
    public class UpdateFreelancerCommand
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<UpdateTelephoneCommand> Telephones { get; set; }
    }
}
