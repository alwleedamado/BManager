using System.ComponentModel.DataAnnotations;

namespace BManager.PublicApi.Features.ProjectFeature.Commands
{
    public class CreateProjectCommand
    {
        [MaxLength(100), Required]
        public string ProjectName { get; set; }
        [MaxLength(200), Required]
        public string Description { get; set; }
        public List<Guid> Teams { get; set; }
        public DateTimeOffset DueDate { get; set; }
        public decimal Price { get; set; }
    }
}
