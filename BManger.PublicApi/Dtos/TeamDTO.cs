namespace BManager.PublicApi.Dtos;

public class TeamDto
{
    public TeamDto(Guid id, string name)
    {
        Id = id;
        Name = name;
    }

    public Guid Id { get; set; }
    public string Name { get; set; }
    
}