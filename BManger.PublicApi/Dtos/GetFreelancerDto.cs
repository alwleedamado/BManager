namespace BManager.PublicApi.Dtos;

public class GetFreelancerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<LookUpEntity> Specialities { get; set; }
}