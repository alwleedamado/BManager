namespace BManager.PublicApi.Dtos.SpecialityType;

public class GetSpecialityTypeDto
{
    public GetSpecialityTypeDto(Guid id, string name, string description)
    {
        Id = id;
        this.name = name;
        Description = description;
    }

    public Guid Id { get; set; }
    public string name { get; set; }
    public string Description { get; set; }
}