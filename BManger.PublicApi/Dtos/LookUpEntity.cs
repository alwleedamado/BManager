namespace BManager.PublicApi.Dtos
{
    public class LookUpEntity
    {
        public LookUpEntity(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
