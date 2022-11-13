using BManager.Utils.Abstractions;
using BManager.Utils.Enums;

namespace BManager.Models
{
    public class Telephone : AuditEntity
    {
        public string TelephoneNumber { get; set; }
        public int PersonId { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
