using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Commands.Person
{
    public class UpdateTelephoneCommand
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string TelephoneNumber { get; set; }
        [Required]
        public int PersonId { get; set; }
        [Required]
        public PhoneType PhoneType { get; set; }
    }
}
