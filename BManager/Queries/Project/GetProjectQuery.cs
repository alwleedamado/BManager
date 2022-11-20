using BManager.Queries.Team;
namespace BManager.Queries.Project
{
    public class GetProjectQuery
    {
        public int Id { get; set; }
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public List<GetTeamQuery> Teams { get; set; } = new List<GetTeamQuery>();
        public DateTimeOffset DueDate { get; set; }
        public decimal Price { get; set; }
    }
}
