using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Persons.Commands
{
    public class UpdateTelephoneCommand
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string TelephoneNumber { get; set; }
        [Required]
        public int FreelancerId { get; set; }
        [Required]
        public PhoneType PhoneType { get; set; }
    }
}
