using BManager.Utils.Abstractions;
using BManager.Utils.Enums;

namespace BManager.Application.Entites
{
    public class Telephone : AuditEntity
    {
        public string TelephoneNumber { get; set; }
        public Guid FreelancerId { get; set; }
        public PhoneType PhoneType { get; set; }

    }
}
