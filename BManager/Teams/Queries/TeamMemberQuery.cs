namespace BManager.Teams.Queries
{
    public class TeamMemberQuery
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid FreelancerId { get; set; }
        public decimal Salary { get; set; }
        public Guid SpecialityTypeId { get; set; }
        public string SpecialityType { get; set;}
    }
}
