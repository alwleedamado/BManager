using BManaber.Application.Entites;
using BManaber.Application.Enums;
using BManager.Utils.Abstractions;
using BManager.Utils.Enums;

namespace BManager.Application.Entites
{
    public class Telephone : EntityBase<int>
    {
        public string TelephoneNumber { get; set; }

        public Telephone(PhoneType phoneType,string telephoneNumber)
        {
            TelephoneNumber = telephoneNumber;
            PhoneType = phoneType;
        }

        public Guid FreelancerId { get; set; }
        public PhoneType PhoneType { get; set; }

    }
}
