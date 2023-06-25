using BManager.Application.Enums;

namespace BManager.PublicApi.Dtos;

public class GetTelephoneDto
{
    public GetTelephoneDto(Guid id,PhoneType phoneType, string telephoneNumber)
    {
        Id = id;
        TelephoneNumber = telephoneNumber;
        PhoneType = phoneType;
    }

    public Guid Id { get; set; }
    public PhoneType PhoneType { get; set; }
    public string TelephoneNumber { get; set; }
}