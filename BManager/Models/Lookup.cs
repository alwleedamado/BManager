using BManager.Utils.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace BManager.Models
{
    public class Lookup : AuditEntity
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
    }
}
