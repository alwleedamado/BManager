namespace BManager.Utils
{
    public class AuditEntity : Entity
    {
        public DateTimeOffset CreatedOn
        {
            get;set;
        }
        public DateTimeOffset UpdatedOn
        {
            get;set;
        }
        public int CreatedBy
        {
            get; set;
        }
        public int UpdatedBy
        {
            get;set;
        }
        public DateTimeOffset DeletedOn
        {
            get; set;
        }
        public int DeletedBy
        {
            get;set;
        }
    }
}
