using BManager.Utils.Abstractions;

namespace BManager.Models
{
    public class Team : AuditEntity
    {
        public string Name { get; set; }
        public List<Person> Members { get; set; } = new List<Person>();
    }
}
