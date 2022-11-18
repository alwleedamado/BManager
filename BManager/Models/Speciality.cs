using BManager.Utils.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace BManager.Models
{
    public class Speciality : AuditEntity
    {
        public SpecialityType SpecialityType { get; set; }
        public int PersonId { get; set; }
        public int SpecialityTypeId { get; set; }
    }
}
