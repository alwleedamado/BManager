using BManager.Models;
using BManager.Utils.Enums;

namespace BManager.Dtos.Person
{
    public class PersonGetDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<Telephone> Telephones { get; set; }
    }
}
