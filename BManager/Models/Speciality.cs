using BManager.Utils.Abstractions;

namespace BManager.Models
{
    public class Speciality : AuditEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
