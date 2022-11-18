namespace BManager.Commands.Team
{
    public class CreateTeamCommand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<int> Members { get; set; }
    }
}
