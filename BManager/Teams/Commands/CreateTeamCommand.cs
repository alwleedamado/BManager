namespace BManager.Teams.Commands
{
    public class CreateTeamCommand
    {
        public string Name { get; set; }
        public IList<Guid>? Members { get; set; }
    }
}
