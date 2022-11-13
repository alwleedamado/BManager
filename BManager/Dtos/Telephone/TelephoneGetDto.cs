using BManager.Utils.Enums;

namespace BManager.Dtos.Telephone
{
    public class TelephoneGetDto
    {
        public int Id { get; set; }
        public string TelephoneNumber { get; set; }
        public int PersonId { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
