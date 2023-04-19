namespace BManager.Teams.Commands
{
    public class CreateTeamCommand
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public IList<Guid> Members { get; set; }
    }
}
