using BManager.Utils.Abstractions;

namespace BManager.Models
{
    public class MemberRole : AuditEntity
    {
        public int SpecialityTypeId { get; set; }
        public SpecialityType SpecialityType { get; set; }
    }
}
