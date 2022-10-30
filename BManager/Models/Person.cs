using BManager.Utils.Abstractions;
using BManager.Utils.Enums;

namespace BManager.Models
{
    public class Person : AuditEntity
    {
        public string Name
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public Gender Gender
        {
            get; set;
        }
        public List<Telephone> Telephones
        {
            get; set;
        } = new List<Telephone>();

    }
}
