using BManaber.Application.Entites;
using BManager.Utils.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace BManager.Application.Entites.FreelancerAggregate
{
    public class SpecialityType : EntityBase<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
