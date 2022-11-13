using BManager.Utils.Abstractions;
using BManager.Utils.Enums;
using System.ComponentModel.DataAnnotations;

namespace BManager.Models
{
    public class Person : AuditEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<Telephone> Telephones { get; set; } = new List<Telephone>();
        public List<Speciality> Specialities { get; set; } = new List<Speciality>();
    }
}
