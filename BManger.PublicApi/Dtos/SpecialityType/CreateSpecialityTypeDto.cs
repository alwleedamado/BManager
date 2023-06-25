namespace BManager.PublicApi.Dtos.SpecialityType;

public class CreateSpecialityTypeDto
{
    public CreateSpecialityTypeDto(string name, string description)
    {
        this.name = name;
        Description = description;
    }

    public string name { get; set; }
    public string Description { get; set; }
}