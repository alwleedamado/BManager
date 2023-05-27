namespace BManager.Application.Exceptions
{
    public class TeamMemberNotFoundException : Exception
    {
        public TeamMemberNotFoundException() : base("Team member not found in this team") { }
    }
}
