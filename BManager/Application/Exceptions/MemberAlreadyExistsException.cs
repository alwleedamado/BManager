namespace BManager.Application.Exceptions
{
    public class MemberAlreadyExistsException : Exception
    {
        public MemberAlreadyExistsException() : base("Member already exists in this team") { }
    }
}
