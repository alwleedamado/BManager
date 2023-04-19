using BManager.Dtos.SpecialityType;
using BManager.Models;
using BManager.Utils.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BManager.Persons.Queries
{
    public class GetPersonQuery
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public Gender Gender { get; set; }
        public List<GetTelephoneQuery> Telephones { get; set; }
        public List<GetSpecialityQuery> Specialities { get; set; }
    }
}
