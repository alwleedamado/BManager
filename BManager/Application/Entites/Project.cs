using BManager.Application.Entites.TeamAggregate;
using BManager.Utils.Abstractions;

namespace BManager.Application.Entites
{
    public class Project : AuditEntity
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<Team> Teams { get; set; } = new List<Team>();
        public DateTimeOffset DueDate { get; set; }
        public decimal Price { get; set; }
    }
}
