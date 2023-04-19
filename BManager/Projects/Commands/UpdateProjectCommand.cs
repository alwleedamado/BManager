using System.ComponentModel.DataAnnotations;

namespace BManager.Projects.Commands
{
    public class UpdateProjectCommand
    {
        [Required]
        public Guid Id { get; set; }
        [Required, MaxLength(100)]
        public string ProjectName { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
        public List<Guid> Teams { get; set; }
        public DateTimeOffset DueDate { get; set; }
        public decimal Price { get; set; }
    }
}
