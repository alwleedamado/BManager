using BManager.Utils.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BManager.Persons.Queries
{
    public class GetTelephoneQuery
    {
        public int Id { get; set; }
        public string TelephoneNumber { get; set; }
        public int PersonId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PhoneType PhoneType { get; set; }
    }
}
