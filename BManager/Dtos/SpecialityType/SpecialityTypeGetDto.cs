using System.ComponentModel.DataAnnotations;

namespace BManager.Dtos.SpecialityType
{
    public class SpecialityTypeGetDto
    {
        public Guid Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
    }
}
